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
    public partial class Form1 : Form
    {
        Graphics g;
        private int przesuniecie = -10;
        public Form1()
        {
            InitializeComponent();
            g = Graphics.FromHwnd(this.Handle);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
           
            Pen pen = new Pen(Color.Red);
            g.DrawRectangle(pen, new Rectangle(przesuniecie+=10, 0, 10, 10));
        }

    }
}
