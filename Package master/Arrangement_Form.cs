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
    public partial class Arrangement_Form : Form
    {
        internal List<Package> Packages_to_container = new List<Package>();
        private bool First_move;
        public Arrangement_Form()
        {
            InitializeComponent();
            this.AutoScroll = true;
            First_move = true;
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
           
        }

        private void Arrangement_Form_Scroll(object sender, ScrollEventArgs e)
        {
            this.Invalidate(true);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)//Packing angorithm
        {
            Form1 Parent_form = (Form1)this.Owner;
            Graphics g = e.Graphics;
            g.FillRectangle(new SolidBrush(Color.WhiteSmoke), 0, 0, Parent_form.Main_Container.Widht_100(), Parent_form.Main_Container.Height_100());
            g.DrawRectangle(new Pen(Color.Black), 0,0,Parent_form.Main_Container.Widht_100(), Parent_form.Main_Container.Height_100());
            if (First_move)
            {
                //przenoszenie paczek do wewnętrznej listy
                foreach (KeyValuePair<Package, int> t in Parent_form.Packages_in_container)
                {
                    for (int i = 0; i < t.Value; i++)
                    {
                        t.Key.ReverseForHeight();//ustawianie paczek "pionowo"
                        Packages_to_container.Add(t.Key);
                    }
                }

                Packages_to_container.Sort();//sortowanie od najdłuższych do najkrótszych
                foreach (Package p in Packages_to_container)
                {
                    lPackages_in_container_list.Items.Add(p.ToString());
                }



               // Rectangle container = new Rectangle(0, 0, (int)Parent_form.Main_Container.Widht_100(), (int)Parent_form.Main_Container.Height_100());

                
                First_move = false;
            }
            Point start_point = new Point(0, 0);
            int Width_left = (int)Parent_form.Main_Container.Widht_100();
            int Height_left=0;
            foreach (Package t in Packages_to_container)
            {
                //Random randomGen = new Random();
                // KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
                //KnownColor randomColorName = names[randomGen.Next(names.Length)];
                // Color randomColor = Color.FromKnownColor(randomColorName);

                if (Width_left >= t.Widht_100())
                {
                    if (t.Height_100() > Height_left)
                    {
                        Height_left = (int)t.Height_100();
                    }

                    g.DrawRectangle(new Pen(Color.Black), start_point.X, start_point.Y, t.Widht_100(), t.Height_100());
                    start_point.X += (int)t.Widht_100();
                    Width_left -= (int)t.Widht_100();
                }
                else
                {
                    start_point.X = 0;
                    start_point.Y += Height_left;
                    Width_left= (int)Parent_form.Main_Container.Widht_100();
                    g.DrawRectangle(new Pen(Color.Black), start_point.X, start_point.Y, t.Widht_100(), t.Height_100());
                    start_point.X += (int)t.Widht_100();
                    Width_left -= (int)t.Widht_100();
                    Height_left = (int)t.Height_100();
                }
                

            }
        }
    }
}
