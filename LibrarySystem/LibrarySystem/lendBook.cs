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
    public partial class lendBook : UserControl
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["LibrarySystemConnectionString"].ConnectionString;

        public lendBook()
        {
            InitializeComponent();
        }

        private void lendBook_Load(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.databaseDataSet.Books);
            this.usersTableAdapter.Fill(this.databaseDataSet.Users);
        }

        private void lendButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 || dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one book and one user to lend books.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        foreach (DataGridViewRow bookRow in dataGridView1.SelectedRows)
                        {
                            int bookID = (int)bookRow.Cells["bookIDDataGridViewTextBoxColumn"].Value;

                            foreach (DataGridViewRow userRow in dataGridView2.SelectedRows)
                            {
                                int userID = (int)userRow.Cells["userIDDataGridViewTextBoxColumn"].Value;

                                using (SqlCommand cmd = new SqlCommand("LendBook", conn, tran))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@UserID", userID);
                                    cmd.Parameters.AddWithValue("@BookID", bookID);

                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        tran.Commit();
                        MessageBox.Show("Books lent successfully.");
                        this.booksTableAdapter.Fill(this.databaseDataSet.Books);
                        this.usersTableAdapter.Fill(this.databaseDataSet.Users);
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Error lending books: " + ex.Message);
                    }
                }
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().ShowDialog();
            this.Show();
        }

    }
}

