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
    public partial class reserveBook : UserControl
    {
        public reserveBook()
        {
            InitializeComponent();
        }

        private void reserveBook_Load(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.databaseDataSet.Books);
        }

        private void reserverButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one book to reserve.");
                return;
            }

            int userID;

            if (!int.TryParse(memberIDTextBox.Text, out userID))
            {
                MessageBox.Show("Please enter a valid user ID.");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["LibrarySystemConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlTransaction tran = conn.BeginTransaction())
                    {
                        try
                        {
                            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                            {
                                int bookID = (int)row.Cells["bookIDDataGridViewTextBoxColumn"].Value;
                                int quantity = 1; // assuming each reservation is for one book

                                using (SqlCommand cmd = new SqlCommand("ReserveBook", conn, tran))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@BookID", bookID);
                                    cmd.Parameters.AddWithValue("@Availability", "Reserved");
                                    cmd.Parameters.AddWithValue("@Quantity", quantity);

                                    cmd.ExecuteNonQuery();
                                }
                            }

                            tran.Commit();
                            MessageBox.Show("Books reserved successfully.");
                            this.booksTableAdapter.Fill(this.databaseDataSet.Books);
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            MessageBox.Show("Error reserving books: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reserving books: " + ex.Message);
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
