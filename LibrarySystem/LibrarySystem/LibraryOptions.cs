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
    public partial class LibraryOptions : Form
    {
        public LibraryOptions()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().ShowDialog();
            this.Close();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add addControl = new Add();
            addControl.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(addControl);
        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(search);
        }

        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addMember addmemberControl = new addMember();
            addmemberControl.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(addmemberControl);
        }

        private void modifyBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifyBook modify = new modifyBook();
            modify.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(modify);
        }

        private void reserverBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reserveBook reserveBookControl = new reserveBook();
            reserveBookControl.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(reserveBookControl);
        }

        private void lendBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lendBook lendControl = new lendBook();
            lendControl.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(lendControl);
        }
    }
}
