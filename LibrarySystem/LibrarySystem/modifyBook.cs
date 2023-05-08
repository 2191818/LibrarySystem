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
    public partial class modifyBook : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["LibrarySystemConnectionString"].ConnectionString;
        public modifyBook()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibraryOptions l1 = new LibraryOptions();
            l1.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().ShowDialog();
            this.Show();
        }

        private void resetViewButton_Click(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.databaseDataSet.Books);

            this.bookTextBox.Text = string.Empty;
            this.titleTextBox.Text = string.Empty;
            this.authorTextBox.Text = string.Empty;
            this.publisherTextBox.Text = string.Empty;
            this.isbnTextBox.Text = string.Empty;
            this.priceTextBox.Text = string.Empty;
            this.quantityTextBox.Text = string.Empty;
            this.availabilityTextBox.Text = string.Empty;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int bookId;
            if (!int.TryParse(bookTextBox.Text, out bookId))
            {
                MessageBox.Show("Please enter a valid book ID.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand("DELETE FROM Books WHERE BookId = @BookId", connection);
                        command.Parameters.AddWithValue("@BookId", bookId);
                        command.ExecuteNonQuery();

                        connection.Close();
                    }

                    this.booksTableAdapter.Fill(this.databaseDataSet.Books);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void modifyBook_Load_1(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.databaseDataSet.Books);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int bookId;
            if (!int.TryParse(bookTextBox.Text, out bookId))
            {
                MessageBox.Show("Please enter a valid book ID.");
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Books WHERE BookId = @BookId", connection);
                    command.Parameters.AddWithValue("@BookId", bookId);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        bookTextBox.Text = reader["BookID"].ToString();
                        titleTextBox.Text = reader["Title"].ToString();
                        authorTextBox.Text = reader["Author"].ToString();
                        publisherTextBox.Text = reader["Publisher"].ToString();
                        isbnTextBox.Text = reader["ISBN"].ToString();
                        priceTextBox.Text = reader["Price"].ToString();
                        quantityTextBox.Text = reader["Quantity"].ToString();
                        availabilityTextBox.Text = reader["Availability"].ToString();
                    }

                    reader.Close();
                    connection.Close();
                }

                this.booksTableAdapter.Fill(this.databaseDataSet.Books);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
