﻿using System;
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
    public partial class Arrangement_Form : Form
    {
        
        public Arrangement_Form()
        {
            InitializeComponent();
            
            //gDraw = Graphics.FromHwnd(this.Handle);
            this.AutoScroll = true;
            //this.inva
            
                   
        }

        private void gContainer_Enter(object sender, EventArgs e)
        {

        }

       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Arrangement_Form_Load(object sender, EventArgs e)
        {

        }

        private void Arrangement_Form_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = e.Graphics;
            //g.DrawRectangle(new Pen(Color.Red), 0, 0, 50, 50);
        }

        private void Arrangement_Form_Scroll(object sender, ScrollEventArgs e)
        {
            this.Invalidate(true);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Form1 Parent_form = (Form1)this.Owner;
            Graphics g = e.Graphics;
            g.DrawRectangle(new Pen(Color.Red), 0,0,Parent_form.Main_Container.Width/10,Parent_form.Main_Container.Height/10);
        }
    }
}