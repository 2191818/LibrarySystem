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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "user") {
                UserOptions u1 = new UserOptions();
                u1.Show();
            } else
            {
                MessageBox.Show("Incorrect Password");
            }
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
