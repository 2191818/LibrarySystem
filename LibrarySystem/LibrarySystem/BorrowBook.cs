using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace LibrarySystem
{
    public partial class borrowBook : UserControl
    {
        public borrowBook()
        {
            InitializeComponent();
        }

        private void borrowBook_Load(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.databaseDataSet.Books);
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to borrow.");
                return;
            }

            int bookID = (int)dataGridView1.SelectedRows[0].Cells["bookIDDataGridViewTextBoxColumn"].Value;
            int memberID = int.Parse(memberIDTextBox.Text);
            DateTime transactionDate = DateTime.Now;

            string connectionString = ConfigurationManager.ConnectionStrings["LibrarySystemConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("BorrowBook", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BookID", bookID);
                    cmd.Parameters.AddWithValue("@MemberID", memberID);
                    cmd.Parameters.AddWithValue("@TransactionDate", transactionDate);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Book borrowed successfully.");

            this.booksTableAdapter.Fill(this.databaseDataSet.Books);
        }

    }
}
