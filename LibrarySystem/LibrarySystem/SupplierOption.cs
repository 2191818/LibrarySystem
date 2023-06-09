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
    public partial class SupplierOptions : Form
    {
        public SupplierOptions()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().ShowDialog();
            this.Close();
        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search searchControl = new Search();
            searchControl.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(searchControl);
            Search search = new Search();
            search.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(search);
        }

        private void sellBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sell sellControl = new Sell();
            sellControl.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(sellControl);
            Sell sell = new Sell();
            sell.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(sell);
        }
    }
}
