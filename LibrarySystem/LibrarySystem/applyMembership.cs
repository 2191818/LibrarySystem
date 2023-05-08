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
    public partial class applyMembership : UserControl
    {
        public applyMembership()
        {
            InitializeComponent();
        }

        private void applyMembership_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.databaseDataSet.Users);
            this.membersTableAdapter.Fill(this.databaseDataSet.Members);
        }

        private void applyMembershipButton_Click(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
