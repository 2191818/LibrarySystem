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

        private void applyMembershipButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to add to membership.");
                return;
            }

            int userID = (int)dataGridView2.SelectedRows[0].Cells["userIDDataGridViewTextBoxColumn"].Value;
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string adress = adressTextBox.Text;
            string phone = phoneTextBox.Text;
            string email = emailTextBox.Text;
            string membershipStatus = membershipStatusTextBox.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["LibrarySystemConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("addMember", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Adress", adress);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@MembershipStatus", membershipStatus);

                    conn.Open();
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Membership applied successfully.");
                    this.membersTableAdapter.Fill(this.databaseDataSet.Members);
                }
            }

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

