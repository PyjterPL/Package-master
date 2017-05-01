using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Package_master
{
    public partial class Package_Input_Dialog : Form
    {
        public Package_Input_Dialog()
        {
            InitializeComponent();
        }

        private void B_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BAdd_Package_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
