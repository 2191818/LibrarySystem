using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class addMember : UserControl
    {
        public addMember()
        {
            InitializeComponent();
        }

        private void addMember_Load(object sender, EventArgs e)
        {
            this.membersTableAdapter.Fill(this.databaseDataSet.Members);
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            string UserID = userIDTextBox.Text;
            string FirstName = firstNameTextBox.Text;
            string LastName = lastNameTextBox.Text;
            string Address = adressTextBox.Text;
            string Phone = phoneTextBox.Text;
            string Email = emailTextBox.Text;
            string MembershipStatus = membershipStatusTextBox.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["LibrarySystemConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("AddMember", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserID", UserID);
                        cmd.Parameters.AddWithValue("@FirstName", FirstName);
                        cmd.Parameters.AddWithValue("@LastName", LastName);
                        cmd.Parameters.AddWithValue("@Address", Address);
                        cmd.Parameters.AddWithValue("@Phone", Phone);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@MembershipStatus", MembershipStatus);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                userIDTextBox.Clear();
                firstNameTextBox.Clear();
                lastNameTextBox.Clear();
                adressTextBox.Clear();
                phoneTextBox.Clear();
                emailTextBox.Clear();
                membershipStatusTextBox.Clear();

                MessageBox.Show("Member added successfully.");

                this.membersTableAdapter.Fill(this.databaseDataSet.Members);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding member: " + ex.Message);
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
