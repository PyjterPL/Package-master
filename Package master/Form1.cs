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
        private List<Package> Paczki = new List<Package>();
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
           
            Pen pen = new Pen(Color.Black);
            int i = listBox1.SelectedIndex;
            if (i > -1)
            {
                gRysuj.DrawRectangle(pen,Paczki[i].Size);
            }
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool can_add = true;
            Package temp = new Package((int)Height_numeric_updown.Value, (int)Weight_numericUpDown.Value);
            
            foreach (Package t in Paczki)
            {
                if (t.ToString() == temp.ToString())
                {
                    MessageBox.Show("Taka paczka została już zdefiniowana");
                    can_add = false;
                }
            }

            if (can_add)
            {
                Paczki.Add(temp);
                listBox1.Items.Add(temp.ToString());
            }   
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
            int i = listBox1.SelectedIndex;
            if (i > -1)
            {
                Paczki.RemoveAt(i);
                listBox1.Items.RemoveAt(i);
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw;
            if (File.Exists("Package_list.txt"))
            {
                File.Delete("Package_list.txt");
            }
           
            sw = File.CreateText("Package_list.txt");
                foreach (Package t in Paczki)
                {
                    sw.WriteLine(t.Size.Width);
                    sw.WriteLine(t.Size.Height);
                }
            sw.Close();
               
            
        }

        private void bLoad_Click(object sender, EventArgs e)
        {

            if (File.Exists("Package_list.txt"))
            {
                String[] tablica;
                //// String x = File.ReadAllText("Package_list.txt");
                // listBox1.Items.Add(x);
                tablica = File.ReadAllLines("Package_list.txt");
                Paczki.Clear();
                listBox1.Items.Clear();
                try
                {
                    for (int i = 0; i < tablica.Length; i += 2)
                    {
                        int w = Int32.Parse(tablica[i]);
                        int h = Int32.Parse(tablica[i + 1]);
                        Package temp = new Package(w, h);
                        Paczki.Add(temp);
                        listBox1.Items.Add(temp);
                    }

                }
                catch (FormatException)
                {
                    MessageBox.Show("Plik jest uszkodzony!");
                    File.Delete("Package_list.txt");
                    //sw.Close();
                }
            }
            else
            {
                MessageBox.Show("Nie znaleziono pliku. Zapisz listę aby utworzyć");
            }

            
        }
    }
}
