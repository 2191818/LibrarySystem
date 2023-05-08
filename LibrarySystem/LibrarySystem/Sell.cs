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
    public partial class Sell : UserControl
    {
        public Sell()
        {
            InitializeComponent();
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LibrarySystemConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string isbn = isbnTextBox.Text;
                decimal price = decimal.Parse(priceTextBox.Text);
                int quantity = int.Parse(quantityTextBox.Text);

                string query = "SELECT COUNT(*) FROM Books WHERE ISBN = @isbn";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@isbn", isbn);
                connection.Open();
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    query = "UPDATE Books SET Quantity = Quantity + @quantity WHERE ISBN = @isbn";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@isbn", isbn);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.ExecuteNonQuery();
                    this.booksTableAdapter.Fill(this.databaseDataSet.Books);
                    MessageBox.Show("Sold " + quantityTextBox.Text + " books of " + isbnTextBox.Text + " at " + priceTextBox.Text + "$");

                    isbnTextBox.Clear();
                    priceTextBox.Clear();
                    quantityTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Book with the given ISBN does not exist.");
                }
            }
        }

        private void Sell_Load(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.databaseDataSet.Books);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupplierOptions s1 = new SupplierOptions();
            s1.ShowDialog();
            Form.ActiveForm.Close();
        }


        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().ShowDialog();
            this.Show();
        }
    }
}
