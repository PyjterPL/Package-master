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
        internal List<Package> Packages_to_container = new List<Package>();
        private bool First_move;

        private List<Rectangle> All_rectangles = new List<Rectangle>();
        private List<Rectangle> Packed_rectangles = new List<Rectangle>();
        private List<Rectangle> Unpackeg_rectangles = new List<Rectangle>();
        private List<Rectangle> Free_Space_rectangles = new List<Rectangle>();
        private List<Color> Packages_Colors = new List<Color>();

        Random randomGen = new Random();//Do generowania losowych kolorów paczek
        KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
        KnownColor randomColorName;
        Color randomColor;

        private bool Alternative_sort = false;
        private bool Free_spaces_viev = false;
        public Arrangement_Form()
        {
            InitializeComponent();
            this.AutoScroll = true;
            First_move = false;

            randomColorName = names[randomGen.Next(names.Length)];
            while (KnownColor.Black == randomColorName)
            {
                randomColorName = names[randomGen.Next(names.Length)];
            }
            randomColor = Color.FromKnownColor(randomColorName);
            c_Free_spaces_viev.Text = "Wolne przestrzenie\r\n(biała obwódka, czerwone wypełnienie)";
            c_Free_spaces_viev.Dispose();//Jeśli chcemy mieć widok tego, co program uważa za wolne przestrzenie ->zakomentować tą linijkę
            //Jeszcze generuje pomniejsze błędy

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
            //W momencie kliknięcia rozpoczyna się całość algorytmu ustawiania paczek
            if (cAlternative_sort.Checked)//Sprawdzenie wersji pakowania
            {
                Alternative_sort = true;
            }
            else
            {
                Alternative_sort = false;
            }
            if (c_Free_spaces_viev.Checked)
            {
                Free_spaces_viev = true;
            }
            else
            {
                Free_spaces_viev = false;
            }
            Main_Form Parent_form = (Main_Form)this.Owner; //Uzyskanie dostępu do składowych okna głównego
            //Czyszczenie wszystkich kontenerów danych
            Packages_to_container.Clear();
            All_rectangles.Clear();
            Packed_rectangles.Clear();
            Unpackeg_rectangles.Clear();
            Free_Space_rectangles.Clear();
            Packages_Colors.Clear();
            lPackages_in_container_list.Items.Clear();
            lUnpacked_packages_list.Items.Clear();
            //Koniec czyszczenia


            //Przenoszenie paczek do wewnętrznej listy z list okna głównego
            foreach (KeyValuePair<Package, int> t in Parent_form.Packages_in_container)
            {
                for (int i = 0; i < t.Value; i++)
                {

                    if (Alternative_sort)
                    {
                        t.Key.ReverseForWidth();//ustawianie paczek "poziomo"
                    }
                    else
                    {
                        t.Key.ReverseForHeight();//ustawianie paczek "pionowo"
                    }
                    Packages_to_container.Add(t.Key);

                }
            }

            Packages_to_container.Sort();//sortowanie od najdłuższych do najkrótszych
            foreach (Package x in Packages_to_container)
            {
                All_rectangles.Add(new Rectangle(0, 0, (int)x.Widht_100(), (int)x.Height_100()));
            }

            //Ustawianie parametów początkowych 
            Point start_point = new Point(0, 0);
            int Width_left = (int)Parent_form.Main_Container.Widht_100();
            int Height_left = 0;
            int Height_in_container_left = (int)Parent_form.Main_Container.Height_100();

            int Rect_in_row = 0;
            int Prev_row_count = 0;


            //Przeglądanie wszystkich paczek
            for (int i = 0; i < All_rectangles.Count; i++)
            {
                //Jeśli nie mieści się w pozostałej wysokości kontenera to wrzuć do listy niespakowanych
                if (start_point.Y + All_rectangles[i].Height > Height_in_container_left)
                {
                    Unpackeg_rectangles.Add(All_rectangles[i]);
                    continue;
                }

                //Jeśli mieści się na szerokość to idź dalej
                if (Width_left >= All_rectangles[i].Width)
                {
                    //Ustala nową wysokość rzędu paczek
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
                    Rect_in_row++;//Zwiększa ilość paczek w rzędzie
                }
                else //Przejście do nowego rzędu
                {
                    bool free_space_filled = false;
                    //Szukanie i dodawanie wolnych prostokątów 
                    for (int j = 0; j < Rect_in_row; j++)
                    {

                        Rectangle free_space = new Rectangle();
                        if (j == Rect_in_row - 1)//Jeśli jest to ostatni element w rzędzie to oblicza wolne pole inaczej
                        {
                            if (Packed_rectangles[Prev_row_count].Width > 0)
                            {
                                free_space.X = Packed_rectangles[Prev_row_count].X + Packed_rectangles[Prev_row_count].Width;
                                free_space.Y = Packed_rectangles[Prev_row_count].Y;
                                free_space.Height = Packed_rectangles[Prev_row_count].Height;
                                free_space.Width = Width_left;
                            }
                        }
                        else //Dla każdego poza ostatnim w rzędzie oblicza wolne pole w rzędzie od największej paczki
                        {
                            if (Packed_rectangles[Prev_row_count].Width > 0)
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
                    Rect_in_row = 0;
                    //Koniec szukania wolnych prostokątów 

                    //Szukanie wolnego miejsca dla prostokątu w momencie przechodzenia do nowego rzędu paczek
                    for (int f = 0; f < Free_Space_rectangles.Count; f++)
                    {
                        Rectangle temporary = All_rectangles[i];
                        temporary.X = Free_Space_rectangles[f].X;
                        temporary.Y = Free_Space_rectangles[f].Y;

                        if (Free_Space_rectangles[f].Contains(temporary))//Jeśli obszar który chcemy dodać mieści się w którymś z wolnych prostokątów to umieść go tam 
                        {                                                //i usuń wolny obszar. Potem podziel to co zostało na nowe, mniejsze wolne obszary

                            All_rectangles[i] = temporary;
                            Packed_rectangles.Add(All_rectangles[i]);
                            Rect_in_row++;

                            free_space_filled = true;
                            Rectangle devided_free_space1 = new Rectangle();
                            Rectangle devided_free_space2 = new Rectangle();
                            //Dodawanie "dolnego" wolnego prostokąta 

                            devided_free_space1.X = temporary.X;
                            devided_free_space1.Y = temporary.Y + temporary.Height;
                            devided_free_space1.Width = Free_Space_rectangles[f].Width;
                            devided_free_space1.Height = Free_Space_rectangles[f].Height - temporary.Height;

                            //dodawanie "bocznego" wolnego prostokąta
                            devided_free_space2.X = temporary.X + temporary.Width;
                            devided_free_space2.Y = temporary.Y;
                            devided_free_space2.Height = temporary.Height;
                            devided_free_space2.Width = (int)Parent_form.Main_Container.Widht_100() - devided_free_space2.X;

                            Free_Space_rectangles.RemoveAt(f);
                            Free_Space_rectangles.Add(devided_free_space1);
                            Free_Space_rectangles.Add(devided_free_space2); 
                            break;
                        }
                    }


                    //Dodawanie nowego rzędu
                    if (!free_space_filled)
                    {
                        start_point.X = 0;
                        start_point.Y += Height_left;
                        Width_left = (int)Parent_form.Main_Container.Widht_100();

                        if (All_rectangles[i].Width > Width_left)
                        {
                            Unpackeg_rectangles.Add(All_rectangles[i]);
                            continue;
                        }
                        if (start_point.Y + All_rectangles[i].Height > Height_in_container_left)
                        {
                            Unpackeg_rectangles.Add(All_rectangles[i]);
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
                        free_space_filled = false;
                    }
                }


            }

            //Kolorowanie poszczególnych paczek
            Rectangle prev_rect = Packed_rectangles.First();


            randomColorName = names[randomGen.Next(names.Length)];
            while (KnownColor.Black == randomColorName)//warunek nie działa, do poprawy
            {
                randomColorName = names[randomGen.Next(names.Length)];
            }
            randomColor = Color.FromKnownColor(randomColorName);
            Packages_Colors.Add(randomColor);

            foreach (Rectangle rect in Packed_rectangles)
            {
                if (!prev_rect.Contains(rect))
                {
                    randomColorName = names[randomGen.Next(names.Length)];
                    while (KnownColor.Black == randomColorName)//warunek nie działa, do poprawy
                    {
                        randomColorName = names[randomGen.Next(names.Length)];
                    }
                    randomColor = Color.FromKnownColor(randomColorName);
                    Packages_Colors.Add(randomColor);
                }


                prev_rect = rect;

            }
            //Koniec kolorowania paczek

            //Przypisywanie umieszczonych i nieumieszczonych w kontenerze paczek do poszczególnych list
            Dictionary<Rectangle, int> Packed_list = new Dictionary<Rectangle, int>();
            foreach (Rectangle packed in Packed_rectangles)
            {
                Rectangle temp = packed;
                temp.X = 0;
                temp.Y = 0;

                if (Packed_list.ContainsKey(temp))
                {

                    Packed_list[temp]++;
                    continue;
                }
                Packed_list.Add(temp, 1);
            }
            foreach (KeyValuePair<Rectangle, int> pair in Packed_list)
            {
                lPackages_in_container_list.Items.Add("Ilość: " + pair.Value.ToString() + " Wymiary: " + pair.Key.Width.ToString() + " x " + pair.Key.Height.ToString());
            }

            Dictionary<Rectangle, int> Unpacked_list = new Dictionary<Rectangle, int>();
            foreach (Rectangle unpacked in Unpackeg_rectangles)
            {
                Rectangle temp = unpacked;
                temp.X = 0;
                temp.Y = 0;

                if (Unpacked_list.ContainsKey(temp))
                {

                    Unpacked_list[temp]++;
                    continue;
                }
                Unpacked_list.Add(temp, 1);
            }
            foreach (KeyValuePair<Rectangle, int> pair in Unpacked_list)
            {
                lUnpacked_packages_list.Items.Add("Ilość: " + pair.Value.ToString() + " Wymiary: " + pair.Key.Width.ToString() + " x " + pair.Key.Height.ToString());
            }
            l_outside_packages.Text = "Paczki poza kontenerem: " + Unpackeg_rectangles.Count.ToString();
            l_in_container_packages.Text = "Paczek w kontenerze: " + Packed_rectangles.Count.ToString();
            
            Invalidate(true);
            First_move = true;

        }



        private void pDraw(object sender, PaintEventArgs e)
        {
            Main_Form Parent_form = (Main_Form)this.Owner;
            Graphics g = e.Graphics;

            g.FillRectangle(new SolidBrush(Color.Wheat), 0, 0, Parent_form.Main_Container.Widht_100(), Parent_form.Main_Container.Height_100());
            g.DrawRectangle(new Pen(Color.Black), 0, 0, Parent_form.Main_Container.Widht_100(), Parent_form.Main_Container.Height_100());

            int i = 0;
            Rectangle prev_rect = new Rectangle();
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
            if (Free_spaces_viev)
            {
                foreach (Rectangle fs in Free_Space_rectangles)
                {
                    g.FillRectangle(new SolidBrush(Color.Red), fs);
                    g.DrawRectangle(new Pen(Color.White), fs);
                }
            }
        }

        private void l_all_packages_Click(object sender, EventArgs e)
        {

        }
    }
}
