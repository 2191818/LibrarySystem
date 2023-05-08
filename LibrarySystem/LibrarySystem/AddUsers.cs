using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibrarySystem
{
    public partial class AddUsers : UserControl
    {
        public AddUsers()
        {
            InitializeComponent();
        }

        private void applyMembership_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.databaseDataSet.Users);
            this.membersTableAdapter.Fill(this.databaseDataSet.Members);
        }

        
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string userType = userTypeTextBox.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["LibrarySystemConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("AddUser", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                       
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@UserType", userType);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                
                usernameTextBox.Clear();
                passwordTextBox.Clear();
                userTypeTextBox.Clear();

                MessageBox.Show("Member added successfully.");

                this.usersTableAdapter.Fill(this.databaseDataSet.Users);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding member: " + ex.Message);
            }
        }
    }
}

