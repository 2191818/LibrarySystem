using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Search : UserControl
    {
        public Search()
        {
            InitializeComponent();
        }
        private void Search_Load(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.databaseDataSet.Books);
        }
        private void restViewButton_Click(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.databaseDataSet.Books);

            this.bookTextBox.Text = string.Empty;
            this.titleTextBox.Text = string.Empty;
            this.authorTextBox.Text = string.Empty;
            this.pubTextBox.Text = string.Empty;
            this.isbnTextBox.Text = string.Empty;
            this.priceTextBox.Text = string.Empty;
            this.quantityTextBox.Text = string.Empty;
            this.availTextBox.Text = string.Empty;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.bookTextBox.Text))
            {
                try
                {
                    this.booksTableAdapter.FillByBook(this.databaseDataSet.Books, int.Parse(this.bookTextBox.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Book ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!string.IsNullOrEmpty(this.titleTextBox.Text))
            {
                try
                {
                    this.booksTableAdapter.FillByTitle(this.databaseDataSet.Books, int.Parse(this.titleTextBox.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!string.IsNullOrEmpty(this.authorTextBox.Text))
            {
                try
                {
                    this.booksTableAdapter.FillByAuthor(this.databaseDataSet.Books, int.Parse(this.authorTextBox.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Author.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!string.IsNullOrEmpty(this.pubTextBox.Text))
            {
                try
                {
                    this.booksTableAdapter.FillByPublisher(this.databaseDataSet.Books, int.Parse(this.pubTextBox.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Publisher.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!string.IsNullOrEmpty(this.isbnTextBox.Text))
            {
                try
                {
                    this.booksTableAdapter.FillByISBN(this.databaseDataSet.Books, int.Parse(this.isbnTextBox.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid ISBN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!string.IsNullOrEmpty(this.priceTextBox.Text))
            {
                try
                {
                    this.booksTableAdapter.FillByPrice(this.databaseDataSet.Books, int.Parse(this.priceTextBox.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!string.IsNullOrEmpty(this.quantityTextBox.Text))
            {
                try
                {
                    this.booksTableAdapter.FillByQuantity(this.databaseDataSet.Books, int.Parse(this.quantityTextBox.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!string.IsNullOrEmpty(this.availTextBox.Text))
            {
                try
                {
                    this.booksTableAdapter.FillByAvailability(this.databaseDataSet.Books, int.Parse(this.availTextBox.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Availability.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void bookTextBox_TextChanged(object sender, EventArgs e)
        {
/*            this.bookTextBox.Text = string.Empty;*/
            this.titleTextBox.Text = string.Empty;
            this.authorTextBox.Text = string.Empty;
            this.pubTextBox.Text = string.Empty;
            this.isbnTextBox.Text = string.Empty;
            this.priceTextBox.Text = string.Empty;
            this.quantityTextBox.Text = string.Empty;
            this.availTextBox.Text = string.Empty;
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            this.bookTextBox.Text = string.Empty;
            this.authorTextBox.Text = string.Empty;
            this.pubTextBox.Text = string.Empty;
            this.isbnTextBox.Text = string.Empty;
            this.priceTextBox.Text = string.Empty;
            this.quantityTextBox.Text = string.Empty;
            this.availTextBox.Text = string.Empty;
        }

        private void authorTextBox_TextChanged(object sender, EventArgs e)
        {
            this.bookTextBox.Text = string.Empty;
            this.titleTextBox.Text = string.Empty;
            this.pubTextBox.Text = string.Empty;
            this.isbnTextBox.Text = string.Empty;
            this.priceTextBox.Text = string.Empty;
            this.quantityTextBox.Text = string.Empty;
            this.availTextBox.Text = string.Empty;
        }

        private void pubTextBox_TextChanged(object sender, EventArgs e)
        {
            this.bookTextBox.Text = string.Empty;
            this.titleTextBox.Text = string.Empty;
            this.authorTextBox.Text= string.Empty;
            this.isbnTextBox.Text = string.Empty;
            this.priceTextBox.Text = string.Empty;
            this.quantityTextBox.Text = string.Empty;
            this.availTextBox.Text = string.Empty;
        }

        private void isbnTextBox_TextChanged(object sender, EventArgs e)
        {
            this.bookTextBox.Text = string.Empty;
            this.titleTextBox.Text = string.Empty;
            this.authorTextBox.Text = string.Empty;
            this.pubTextBox.Text= string.Empty;
            this.priceTextBox.Text = string.Empty;
            this.quantityTextBox.Text = string.Empty;
            this.availTextBox.Text = string.Empty;
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            this.bookTextBox.Text = string.Empty;
            this.titleTextBox.Text = string.Empty;
            this.authorTextBox.Text = string.Empty;
            this.pubTextBox.Text = string.Empty;
            this.isbnTextBox.Text= string.Empty;
            this.quantityTextBox.Text = string.Empty;
            this.availTextBox.Text = string.Empty;
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            this.bookTextBox.Text = string.Empty;
            this.titleTextBox.Text = string.Empty;
            this.authorTextBox.Text = string.Empty;
            this.pubTextBox.Text = string.Empty;
            this.isbnTextBox.Text = string.Empty;
            this.priceTextBox.Text= string.Empty;
            this.availTextBox.Text = string.Empty;
        }

        private void availTextBox_TextChanged(object sender, EventArgs e)
        {
            this.bookTextBox.Text = string.Empty;
            this.titleTextBox.Text = string.Empty;
            this.authorTextBox.Text = string.Empty;
            this.pubTextBox.Text = string.Empty;
            this.isbnTextBox.Text = string.Empty;
            this.priceTextBox.Text = string.Empty;
            this.quantityTextBox.Text = string.Empty;
        }
    }
}
