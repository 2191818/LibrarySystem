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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void libraryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LibraryLogin().ShowDialog();
            this.Close();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserLogin().ShowDialog();
            this.Close();
        }

        private void supplierButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SupplierLogin().ShowDialog();
            this.Close();
        }
    }
}
