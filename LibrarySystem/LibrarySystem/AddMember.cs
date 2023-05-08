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
    public partial class addMember : UserControl
    {
        public addMember()
        {
            InitializeComponent();
        }

        private void addMember_Load(object sender, EventArgs e)
        {
            this.membersTableAdapter.Fill(this.databaseDataSet.Members);
        }
    }
}
