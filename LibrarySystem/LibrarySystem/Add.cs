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
    public partial class Add : UserControl
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.databaseDataSet.Books);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string title = titleTextBox.Text;
            string author = authorTextBox.Text;
            string publisher = publisherTextBox.Text;
            string isbn = isbnTextBox.Text;
            decimal price = decimal.Parse(priceTextBox.Text);
            int quantity = int.Parse(quantityTextBox.Text);

            string connectionString = ConfigurationManager.ConnectionStrings["LibrarySystemConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("AddBook", conn))
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

            titleTextBox.Clear();
            authorTextBox.Clear();
            publisherTextBox.Clear();
            isbnTextBox.Clear();
            priceTextBox.Clear();
            quantityTextBox.Clear();

            MessageBox.Show("Book added successfully.");

            this.booksTableAdapter.Fill(this.databaseDataSet.Books);
        }
    }
}
