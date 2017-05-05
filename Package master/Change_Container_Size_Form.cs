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
    public partial class Change_Container_Size_Form : Form
    {
        public Change_Container_Size_Form()
        {
            InitializeComponent();

            Height_numericUpDown.Minimum = 5;
            Height_numericUpDown.Maximum = 20;
            Width_numericUpDown.Minimum = 1;
            Width_numericUpDown.Maximum = 5;
            Height_numericUpDown.Increment = (decimal)0.01;
            Width_numericUpDown.Increment = (decimal)0.01;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Change_Container_Size_Form_Load(object sender, EventArgs e)
        {

        }

        private void bChange_Click(object sender, EventArgs e)
        {
            Main_Form form = (Main_Form)this.Owner;

            form.Main_Container.Height=(float)Height_numericUpDown.Value;
            form.Main_Container.Width=(float)Width_numericUpDown.Value;
            form.lContainer_size.Text = form.Main_Container.ToString();
            this.Close();
        }
    }
}
