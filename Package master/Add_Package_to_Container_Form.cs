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
    public partial class Add_Package_to_Container_Form : Form
    {
        public Add_Package_to_Container_Form()
        {
            InitializeComponent();
            Packages_to_container_numericUpDown.Minimum = 1;
            Packages_to_container_numericUpDown.Maximum = Int32.MaxValue;

        }

        private void Add_Package_to_Container_Form_Load(object sender, EventArgs e)
        {

        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAdd_to_Container_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)this.Owner;

            int Result = (int)Packages_to_container_numericUpDown.Value;
            if (Result > 0)
            {
                int i = form.lPackage_list.SelectedIndex;

                Package temp = form.Packages[i];
                form.Packages_in_container.Add(temp, Result);
                form.lContainer_packages.Items.Add(Result.ToString()+" x "+temp.ToString());

            }
            this.Close();
        }

        public int CountOfPackages
        {
            get { return (int)Packages_to_container_numericUpDown.Value; }
            
        }

        private void Packages_to_container_numericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
