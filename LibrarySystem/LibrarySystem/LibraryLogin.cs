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
    public partial class LibraryLogin : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["LibrarySystemConnectionString"].ConnectionString;

        public LibraryLogin()
        {
            InitializeComponent();

            ErrorLabel.Text = "";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().ShowDialog();
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string memberID = memberIDTextBox.Text;
            string password = passwordTextBox.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Members m INNER JOIN Users u ON m.UserID = u.UserID WHERE m.MemberID=@MemberID AND u.Password=@Password", conn))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", memberID);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // Valid credentials, show the LibraryOptions form
                            this.Hide();
                            new LibraryOptions().ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            // Invalid credentials, show an error message
                            ErrorLabel.Text = "Incorrect Member ID or Password";
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle SQL errors
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle all other errors
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                okButton_Click(this, new EventArgs());
            }
        }
    }
}

