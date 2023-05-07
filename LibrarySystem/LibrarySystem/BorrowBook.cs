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
            // Get values from textboxes
            string title = titleTextBox.Text;
            string author = authorTextBox.Text;
            string publisher = publisherTextBox.Text;
            string isbn = isbnTextBox.Text;
            decimal price = decimal.Parse(priceTextBox.Text);
            int quantity = int.Parse(quantityTextBox.Text);

            // Execute the stored procedure
            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Chrome\\LibrarySystem\\LibrarySystem\\LibrarySystem\\Database.mdf;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("BorrowBook", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Author", author);
                    cmd.Parameters.AddWithValue("@Publisher", publisher);
                    cmd.Parameters.AddWithValue("@ISBN", isbn);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            // Clear the textboxes
            titleTextBox.Clear();
            authorTextBox.Clear();
            publisherTextBox.Clear();
            isbnTextBox.Clear();
            priceTextBox.Clear();
            quantityTextBox.Clear();

            MessageBox.Show("Book borrowed successfully.");
        }
    }
}
