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
        private List<Color> Packages_Colors = new List<Color>();

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
                Main_Form Parent_form = (Main_Form)this.Owner;
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

            int Rect_in_row = 0;
            int Prev_row_count = 0;
            for (int i = 0; i < All_rectangles.Count; i++)
            {
                //Jeśli nie mieści się w pozostałej wysokości kontenera to wrzuć do listy niespakowanych
                if (start_point.Y + All_rectangles[i].Height > Height_in_container_left)
                {
                    Unpackeg_rectangles.Add(All_rectangles[i]);
                    lUnpacked_packages_list.Items.Add(All_rectangles[i].Width.ToString() + "x" + All_rectangles[i].Height.ToString());
                    continue;
                } 
                //Jeśli mieści się na szerokość to działaj
                if (Width_left >= All_rectangles[i].Width)
                {
                    //ustala nową wysokość rzędu
                    if (All_rectangles[i].Height > Height_left)
                    {
                        Height_left = (int)All_rectangles[i].Height;
                    }
                    //Zmienia współrzędne prostokąta do rysowania
                    Rectangle temp = All_rectangles[i];
                    temp.X = start_point.X;
                    temp.Y = start_point.Y;
                    All_rectangles[i] = temp;



                    Packed_rectangles.Add(All_rectangles[i]);
                    //przesuwa początek rysowania
                    start_point.X += (int)All_rectangles[i].Width;
                    //odejmuje pozostałą szerokość
                    Width_left -= (int)All_rectangles[i].Width;
                    Rect_in_row++;
                }
                else
                {
                    //Przejście do nowego rzędu
                    for (int j = 0; j < Rect_in_row; j++)
                    {
                        
                        Rectangle free_space = new Rectangle();
                        if (j == Rect_in_row - 1)
                        {
                            if (Width_left > 0)
                            {
                                free_space.X = Packed_rectangles[Prev_row_count].X + Packed_rectangles[Prev_row_count].Width;
                                free_space.Y = Packed_rectangles[Prev_row_count].Y;
                                free_space.Height = Packed_rectangles[Prev_row_count].Height;
                                free_space.Width = Width_left;
                            }
                        }
                        else
                        {
                            if (Width_left > 0)
                            {
                                free_space.Height = Packed_rectangles[Prev_row_count].Height - Packed_rectangles[Prev_row_count + 1].Height;
                                free_space.X = Packed_rectangles[Prev_row_count + 1].X;
                                free_space.Y = Packed_rectangles[Prev_row_count + 1].Y + Packed_rectangles[Prev_row_count + 1].Height;
                                free_space.Width = (int)Parent_form.Main_Container.Widht_100() - Packed_rectangles[Prev_row_count + 1].X;
                            }

                        }
                        Free_Space_rectangles.Add(free_space);
                        Prev_row_count++;
                    }
                    Prev_row_count = Rect_in_row;
                    Rect_in_row = 0;
                   

                    
                    start_point.X = 0;
                    start_point.Y += Height_left;
                    Width_left = (int)Parent_form.Main_Container.Widht_100();
                    //jeśli
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
                    Rect_in_row++;
                    start_point.X += (int)All_rectangles[i].Width;
                    Width_left -= (int)All_rectangles[i].Width;
                    Height_left = (int)All_rectangles[i].Height;

                }


            }

            //Kolorowanie poszczególnych paczek
            Rectangle prev_rect = Packed_rectangles.First();

            int Colors_count = 0;
            randomColorName = names[randomGen.Next(names.Length)];
            randomColor = Color.FromKnownColor(randomColorName);
            Packages_Colors.Add(randomColor);
            Colors_count++;
            foreach (Rectangle rect in Packed_rectangles)
            {
                if (rect.Size != prev_rect.Size)
                {
                   randomColorName = names[randomGen.Next(names.Length)];
                    randomColor = Color.FromKnownColor(randomColorName);
                    Packages_Colors.Add(randomColor);
                    Colors_count++;
                }


                prev_rect = rect;

            }
            Invalidate(true);
            First_move = true;
            bDeploy.Dispose();
        }

        private void pDraw(object sender, PaintEventArgs e)
        {
            Main_Form Parent_form = (Main_Form)this.Owner;
            Graphics g = e.Graphics;

            g.FillRectangle(new SolidBrush(Color.Wheat), 0, 0, Parent_form.Main_Container.Widht_100(), Parent_form.Main_Container.Height_100());
            g.DrawRectangle(new Pen(Color.Black), 0, 0, Parent_form.Main_Container.Widht_100(), Parent_form.Main_Container.Height_100());

            int i = 0;
            Rectangle prev_rect=new Rectangle();
            if (First_move)
            {
                prev_rect = Packed_rectangles.First();
            }
            foreach (Rectangle rect in Packed_rectangles)
            {
                if (rect.Size != prev_rect.Size)
                {
                    i++;
                }
                g.FillRectangle(new SolidBrush(Packages_Colors[i]), rect);
                g.DrawRectangle(new Pen(Color.Black), rect);
                
                prev_rect = rect;
            }
            foreach (Rectangle fs in Free_Space_rectangles)
            {
                g.FillRectangle(new SolidBrush(Color.Red), fs);
                g.DrawRectangle(new Pen(Color.Black), fs);
            }

        }
    }
}
