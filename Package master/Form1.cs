using System;
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

    public partial class Form1 : Form
    {
        private Graphics gRysuj;
        internal List<Package> Packages = new List<Package>();
        internal Dictionary<Package, int> Packages_in_container = new Dictionary<Package, int>();
        Add_Package_to_Container_Form Add_Form;
        public Form1()
        {
            InitializeComponent();
            gRysuj = Graphics.FromHwnd(this.Handle);
            Height_numeric_updown.Minimum = 40;
            Height_numeric_updown.Maximum = 400;
            Height_numeric_updown.Value = 120;
            Weight_numericUpDown.Minimum = 40;
            Weight_numericUpDown.Maximum = 400;
            Weight_numericUpDown.Value = 80;
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {           
            Pen pen = new Pen(Color.Tomato);
            
            int i = lPackage_list.SelectedIndex;
            if (i > -1)
            {
                gRysuj.DrawRectangle(pen, Packages[i].Size);
            }
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool can_add = true;
            Package temp = new Package((int)Height_numeric_updown.Value, (int)Weight_numericUpDown.Value);
            
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
                lPackage_list.Items.Add(temp.ToString());
            }   
            
        }

     

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

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
                    sw.WriteLine(t.Size.Width);
                    sw.WriteLine(t.Size.Height);
                }
                sw.Close();
            }
            else
            {
                MessageBox.Show("Lista jest pusta");
            }
        }
        

        private void bLoad_Click(object sender, EventArgs e)
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
                            int h = Int32.Parse(tablica[i]);
                            int w = Int32.Parse(tablica[i + 1]);
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
                    //int Result = CustomDialog.ShowDialog("Ile chcesz dodać?", "Dodawanie do listy");
                    ////int Result = Add_Package_to_Container_Form.
                    //if (Result > 0)
                    //{
                    //    Packages_in_container.Add(Result, temp);
                    //    lContainer_packages.Items.Add(temp.ToString());
                    //}
                }
            }           
        }

        private void Add_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Add_Form = null;
        }
    }
}
