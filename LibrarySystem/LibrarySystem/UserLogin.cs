﻿using System;
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

            ErrorLabel.Text = "";
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LibraryOptions().ShowDialog();
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "user") {
                this.Hide();
                new UserOptions().ShowDialog();
                this.Close();
            } else
            {
                ErrorLabel.Text = "Incorrect Password";
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                okButton_Click(this, new EventArgs());
            }
        }
    }
}
