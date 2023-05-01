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
    public partial class SupplierLogin : Form
    {
        public SupplierLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "supplier")
            {
                SupplierOptions s1 = new SupplierOptions();
                s1.Show();
            }
            else {
                MessageBox.Show("Incorrect Password");
            }
        }

        private void SupplierLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
