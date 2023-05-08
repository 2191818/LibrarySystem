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
    public partial class returnBook : UserControl
    {
        public returnBook()
        {
            InitializeComponent();
        }

        private void returnBook_Load(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.databaseDataSet.Books);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to return.");
                return;
            }

            int bookID = (int)dataGridView1.SelectedRows[0].Cells["bookIDDataGridViewTextBoxColumn"].Value;
            int userID;

            if (!int.TryParse(userIDTextBox.Text, out userID))
            {
                MessageBox.Show("Please enter a valid user ID.");
                return;
            }

            DateTime transactionDate = DateTime.Now;

            string connectionString = ConfigurationManager.ConnectionStrings["LibrarySystemConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("ReturnBook", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@BookID", bookID);
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.Parameters.AddWithValue("@TransactionDate", transactionDate);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Book returned successfully.");
                this.booksTableAdapter.Fill(this.databaseDataSet.Books);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Constraint violation error number
                {
                    MessageBox.Show("Error returning book: The user or book ID is invalid.");
                }
                else
                {
                    MessageBox.Show("Error returning book: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error returning book: " + ex.Message);
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserOptions().ShowDialog();
            this.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().ShowDialog();
            this.Show();
        }
    }
}
