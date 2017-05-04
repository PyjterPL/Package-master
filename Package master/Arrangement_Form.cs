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

        private List<Rectangle> All_rectangles = new List<Rectangle>();
        private List<Rectangle> Packed_rectangles = new List<Rectangle>();
        private List<Rectangle> Unpackeg_rectangles = new List<Rectangle>();
        private List<Rectangle> Free_Space_rectangles = new List<Rectangle>();


        Random randomGen = new Random();
        KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
        KnownColor randomColorName;
        Color randomColor; 



        public Arrangement_Form()
        {
            InitializeComponent();
            this.AutoScroll = true;
            First_move = false;

            randomColorName= names[randomGen.Next(names.Length)];
            randomColor = Color.FromKnownColor(randomColorName);
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

        

        private void bDeploy_Click(object sender, EventArgs e)
        {
                Form1 Parent_form = (Form1)this.Owner;
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
                foreach (Package x in Packages_to_container)
                {
                    All_rectangles.Add(new Rectangle(0, 0, (int)x.Widht_100(), (int)x.Height_100()));
                }
                

                foreach (Package p in Packages_to_container)
                {
                    lPackages_in_container_list.Items.Add(p.ToString());
                }
            ///////////////////

            Point start_point = new Point(0, 0);
            int Width_left = (int)Parent_form.Main_Container.Widht_100();
            int Height_left = 0;
            int Height_in_container_left = (int)Parent_form.Main_Container.Height_100();

            for (int i = 0; i < All_rectangles.Count; i++)
            {

                if (start_point.Y + All_rectangles[i].Height > Height_in_container_left) break;

                if (Width_left >= All_rectangles[i].Width)
                {
                    if (All_rectangles[i].Height > Height_left)
                    {
                        Height_left = (int)All_rectangles[i].Height;
                    }

                    

                    Rectangle temp = All_rectangles[i];
                    temp.X = start_point.X;
                    temp.Y = start_point.Y;
                    All_rectangles[i] = temp;

                    Packed_rectangles.Add(All_rectangles[i]);

                    start_point.X += (int)All_rectangles[i].Width;
                    Width_left -= (int)All_rectangles[i].Width;
                }
                else
                {

                    start_point.X = 0;
                    start_point.Y += Height_left;
                    Width_left = (int)Parent_form.Main_Container.Widht_100();
                    if (All_rectangles[i].Width > Width_left)
                    {
                        Unpackeg_rectangles.Add(All_rectangles[i]);
                        lUnpacked_packages_list.Items.Add(All_rectangles[i].Width.ToString() + "x" + All_rectangles[i].Height.ToString());
                        continue;
                    }
                    if (start_point.Y + All_rectangles[i].Height > Height_in_container_left)
                    {
                        Unpackeg_rectangles.Add(All_rectangles[i]);
                        lUnpacked_packages_list.Items.Add(All_rectangles[i].Width.ToString() + "x" + All_rectangles[i].Height.ToString());
                        continue;
                    }
                    

                    Rectangle temp = All_rectangles[i];
                    temp.X = start_point.X;
                    temp.Y = start_point.Y;
                    All_rectangles[i] = temp;
                    Packed_rectangles.Add(All_rectangles[i]);

                    start_point.X += (int)All_rectangles[i].Width;
                    Width_left -= (int)All_rectangles[i].Width;
                    Height_left = (int)All_rectangles[i].Height;

                }


            }
            Invalidate(true);
            First_move = true;
            bDeploy.Dispose();
        }

        private void pDraw(object sender, PaintEventArgs e)
        {
            Form1 Parent_form = (Form1)this.Owner;
            Graphics g = e.Graphics;

            g.FillRectangle(new SolidBrush(Color.Wheat), 0, 0, Parent_form.Main_Container.Widht_100(), Parent_form.Main_Container.Height_100());
            g.DrawRectangle(new Pen(Color.Black), 0, 0, Parent_form.Main_Container.Widht_100(), Parent_form.Main_Container.Height_100());
            Rectangle prev_rect=new Rectangle();

            if (First_move)
            {
                prev_rect = Packed_rectangles.First();
            }
            foreach (Rectangle rect in Packed_rectangles)
            {
                if (rect.Size != prev_rect.Size)
                {
                    randomColorName = names[randomGen.Next(names.Length)];
                    randomColor = Color.FromKnownColor(randomColorName);

                }
                g.FillRectangle(new SolidBrush(randomColor), rect);
                g.DrawRectangle(new Pen(Color.Black), rect);
               
                prev_rect = rect;

            }

        }
    }
}
