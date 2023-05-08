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
    public partial class SupplierLogin : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["LibrarySystemConnectionString"].ConnectionString;

        public SupplierLogin()
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
            string supplierID = supplierIDTextBox.Text;
            string password = passwordTextBox.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Suppliers s INNER JOIN Users u ON s.UserID = u.UserID WHERE s.SupplierID = @SupplierID AND u.Password = @Password", conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // Valid credentials, show the SupplierOptions form
                            this.Hide();
                            new SupplierOptions().ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            // Invalid credentials, show an error message
                            ErrorLabel.Text = "Incorrect SupplierID or Password";
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error logging in: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                okButton_Click(this, new EventArgs());
            }
        }
    }
}
