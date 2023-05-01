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
    public partial class LibraryLogin : Form
    {
        public LibraryLogin()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "library")
            {
                LibraryOptions l1 = new LibraryOptions();
                l1.Show();
            }
            else {
                MessageBox.Show("Incorrect Password");
            }
        }

        private void LibraryLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
