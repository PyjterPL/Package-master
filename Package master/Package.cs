using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Package_master
{
    //Klasa odpowiedzialna za reprezentację paczek
    class Package : IComparable
    {

        private float width;
        public float Width
        {
            get { return width; }
        }

        private float height;
        public float Height
        {
            get { return height; }
        }

        //konstruktory
        public Package(float Height, float Width)
        {
            if (Height < 0.4 || Width < 0.4 || Height > 4 || Width > 4)
            {
                throw new Exception("Podano złe rozmary paczki!!");
            }
            else
            {
                //size = new Rectangle(0, 0, Width, Height);//Point reprezentuje lewy góry róg
                this.width = Width;
                this.height = Height;

            }
        }
        public Package()
        {
            //size = new Rectangle(0, 0, 120, 80);//Point reprezentuje lewy góry róg
            width = 0.8f;
            height = 1.2f;

        }


        public float Widht_100()//wartość zwracana dla potrzeb rysowania
        {
            return width * 100;
        }
        public float Height_100()//wartość zwracana dla potrzeb rysowania
        {
            return height * 100;
        }

    
        public override string ToString()
        {
            return height.ToString() + " x " +width.ToString();
        }

        public int CompareTo(object obj) //Porównywanie wg długości
        {
            Package that = (Package)obj;
            if (this.height == that.height) return 0;
            if (this.height > that.height) return -1;
            return 1;
            
        }


        public void ReverseForHeight() //W celu układania paczek podłużnie można tą funkcją je obracać, aby zawsze były układane względem długości
        {
            if (this.width > this.height)
            {
                float buff = this.width;
                this.width = this.height;
                this.height = buff;
            }
        }
        public void ReverseForWidth() //W celu układania paczek podłużnie można tą funkcją je obracać, aby zawsze były układane względem długości
        {
            if (this.width < this.height)
            {
                float buff = this.width;
                this.width = this.height;
                this.height = buff;
            }
        }

       
    }
}
