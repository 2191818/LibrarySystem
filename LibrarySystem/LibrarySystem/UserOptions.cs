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
    public partial class UserOptions : Form
    {
        public UserOptions()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().ShowDialog();
            this.Close();
        }

        private void UserOptions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.databaseDataSet.Books);
        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(search);
        }

        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrowBook borrowControl = new borrowBook();
            borrowControl.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(borrowControl);
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            returnBook returnControl = new returnBook();
            returnControl.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(returnControl);
        }

        private void applyMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            applyMembership applyControl = new applyMembership();
            applyControl.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(applyControl);
        }
    }
}
