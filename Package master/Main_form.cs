﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
namespace Package_master
{

    public partial class Main_Form : Form
    {
        
        internal List<Package> Packages = new List<Package>();
        internal Dictionary<Package, int> Packages_in_container = new Dictionary<Package, int>();
        Add_Package_to_Container_Form Add_Form;//Forma do dodawania nowych paczek
        Change_Container_Size_Form Change_Form;//Forma do zmiany rozmiarów kontenera
        Arrangement_Form arrangement_form; //Forma do wizualizacji rozmieszczenia paczek
        internal Container Main_Container;



        public Main_Form()
        {
            InitializeComponent();
            Main_Container = new Container();
            Height_numeric_updown.Minimum = (decimal)0.4;
            Height_numeric_updown.Maximum = 4;
            Height_numeric_updown.Value = (decimal)1.2;
            Width_numericUpDown.Minimum = (decimal)0.4;
            Width_numericUpDown.Maximum = 4;
            Width_numericUpDown.Value = (decimal)0.8;
            Width_numericUpDown.Increment = (decimal)0.01;
            Height_numeric_updown.Increment = (decimal)0.01;
            lContainer_size.Text = Main_Container.ToString();  
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LHeight_Click(object sender, EventArgs e)
        {

        }

        private void BDelete_Package_Click(object sender, EventArgs e)
        {
            int i = lPackage_list.SelectedIndex;
            if (i > -1)
            {
                Packages.RemoveAt(i);
                lPackage_list.Items.RemoveAt(i);
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (Packages.Count > 0)
            {
                StreamWriter sw;
                if (File.Exists("Package_list.txt"))
                {
                    File.Delete("Package_list.txt");
                }

                sw = File.CreateText("Package_list.txt");
                foreach (Package t in Packages)
                {
                    sw.WriteLine(t.Width);
                    sw.WriteLine(t.Height);
                }
                sw.Close();
            }
            else
            {
                MessageBox.Show("Lista jest pusta");
            }
        }
        

        private void bLoad_Click(object sender, EventArgs e)//Wczytywanie z pliku
        {

            if (File.Exists("Package_list.txt"))
            {
                String[] tablica;
                tablica = File.ReadAllLines("Package_list.txt");
                if (tablica.Length > 1)
                {
                    Packages.Clear();
                    lPackage_list.Items.Clear();
                    try
                    {
                        for (int i = 0; i < tablica.Length; i += 2)
                        {
                            float h = float.Parse(tablica[i]);
                            float w = float.Parse(tablica[i + 1]);
                            Package temp = new Package(w, h);
                            Packages.Add(temp);
                            lPackage_list.Items.Add(temp);
                        }

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Plik jest uszkodzony!");
                        File.Delete("Package_list.txt");
                    }
                }
                else
                {
                    MessageBox.Show("Plik jest pusty. Zapisz wypełnioną listę");
                }
            }
            else
            {
                MessageBox.Show("Nie znaleziono pliku. Zapisz listę aby utworzyć");
            }

            
        }

        private void lPackage_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bContainerAdd_Click(object sender, EventArgs e)
        {

            int i = lPackage_list.SelectedIndex;
            if (i > -1)
            {
                Package temp = Packages[i];
                if (Packages_in_container.ContainsKey(temp))
                {
                    MessageBox.Show("Ta paczka znajduje się już w kontenerze");
                }
                else
                {
                    if (Add_Form == null)
                    {
                        Add_Form = new Add_Package_to_Container_Form();
                        Add_Form.Owner = this;
                        Add_Form.FormClosed += Add_Form_FormClosed;
                        Add_Form.Show();
                    }
                    else
                    {
                        Add_Form.Activate();
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Wybierz paczkę z listy zdefiniowanych paczek");
            }
        }

        private void Add_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Add_Form = null;
        }

        private void lContainer_packages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bDelete__from_Container_Click(object sender, EventArgs e)
        {
            int i = lContainer_packages.SelectedIndex;
            if (i > -1)
            {
                Package temp = Packages_in_container.ElementAt(i).Key;
                Packages_in_container.Remove(temp);
                lContainer_packages.Items.RemoveAt(i);
            }
            else
            {
                MessageBox.Show("Wybierz element do usunięcia");
            }
        }

        private void bContainer_size_change_Click(object sender, EventArgs e)
        {
            
            if (Change_Form == null)
            {
                Change_Form = new Change_Container_Size_Form();
                Change_Form.Owner = this;               
                Change_Form.FormClosed += Change_Form_FormClosed;
                Change_Form.Show();
            }
            else
            {
                Change_Form.Activate();
            }
        }

        private void Change_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Change_Form = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bArrange_Click(object sender, EventArgs e)
        {
           
            if (Packages_in_container.Count > 0)
            {
                if (arrangement_form == null)
                {

                    arrangement_form = new Arrangement_Form();
                    arrangement_form.pDrawningPanel.Width = (int)(Main_Container.Widht_100()+1);//;+ 50;
                    arrangement_form.pDrawningPanel.Height = (int)(Main_Container.Height_100()+1);// + 100;
                    arrangement_form.lPackages_in_container_list.Left = arrangement_form.pDrawningPanel.Width+5;
                    arrangement_form.l_in_container_packages.Left = arrangement_form.pDrawningPanel.Width + 5;
                    arrangement_form.l_outside_packages.Left = arrangement_form.pDrawningPanel.Width + 5;
                    arrangement_form.lUnpacked_packages_list.Left = arrangement_form.pDrawningPanel.Width + 5;
                    arrangement_form.bDeploy.Left = arrangement_form.pDrawningPanel.Width + 5;
                    arrangement_form.cAlternative_sort.Left = arrangement_form.pDrawningPanel.Width + 5;
                    arrangement_form.c_Free_spaces_viev.Left = arrangement_form.pDrawningPanel.Width + 5;

                    arrangement_form.Text = "Kontener " + Main_Container.ToString();

                    arrangement_form.Owner = this;
                    arrangement_form.FormClosed += Arrangement_form_FormClosed;

                    arrangement_form.Show();
                }
                else
                {
                    arrangement_form.Activate();
                }
            }
            else
            {
                MessageBox.Show("Dodaj paczki do kontenera");
            }
        }

        private void Arrangement_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            arrangement_form = null;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void bClear_Container_Click(object sender, EventArgs e)
        {
            Packages_in_container.Clear();
            lContainer_packages.Items.Clear();
        }

        private void Add_Define_package_click(object sender, EventArgs e)
        {
            bool can_add = true;
            Package temp = new Package((float)Height_numeric_updown.Value, (float)Width_numericUpDown.Value);

            foreach (Package t in Packages)
            {
                if (t.ToString() == temp.ToString())
                {
                    MessageBox.Show("Taka paczka została już zdefiniowana");
                    can_add = false;
                }
            }

            if (can_add)
            {
                Packages.Add(temp);
                Packages.Sort();
                lPackage_list.Items.Clear();
                foreach (Package t in Packages)
                {
                    lPackage_list.Items.Add(t.ToString());
                }
            }
        }
    }
}
