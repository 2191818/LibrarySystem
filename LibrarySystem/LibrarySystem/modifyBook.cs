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
            new LibraryOptions().ShowDialog();
            this.Show();
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

                    SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Books WHERE BookId = @BookId", connection);
                    command.Parameters.AddWithValue("@BookId", bookId);

                    int count = (int)command.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("The book ID does not exist.");
                        return;
                    }

                    command = new SqlCommand("UPDATE Books SET Title = @Title, Author = @Author, Publisher = @Publisher, ISBN = @ISBN, Price = @Price, Quantity = @Quantity, Availability = @Availability WHERE BookId = @BookId", connection);
                    command.Parameters.AddWithValue("@BookId", bookId);
                    command.Parameters.AddWithValue("@Title", titleTextBox.Text);
                    command.Parameters.AddWithValue("@Author", authorTextBox.Text);
                    command.Parameters.AddWithValue("@Publisher", publisherTextBox.Text);
                    command.Parameters.AddWithValue("@ISBN", isbnTextBox.Text);
                    command.Parameters.AddWithValue("@Price", priceTextBox.Text);
                    command.Parameters.AddWithValue("@Quantity", quantityTextBox.Text);
                    command.Parameters.AddWithValue("@Availability", availabilityTextBox.Text);

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
