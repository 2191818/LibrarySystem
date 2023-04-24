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

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void libraryButton_Click(object sender, EventArgs e)
        {
            LibraryLogin l1 = new LibraryLogin();
            l1.Show();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            UserLogin u1 = new UserLogin(); 
            u1.Show();  
        }

        private void supplierButton_Click(object sender, EventArgs e)
        {
            SupplierLogin s1 = new SupplierLogin();
            s1.Show();
        }
    }
}
