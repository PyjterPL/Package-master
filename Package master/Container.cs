using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Package_master
{
    class Container
    {
        //- kontener jest prostokątem, jego rozmiar powinien być konfigurowalny
        //(w zakresie długość: 5-20 m szerokość: 1 – 5 m - domyślnie 13,6 x 2,4),

        //private Rectangle Size { get; set; }
        private Rectangle size;

        public Rectangle Size
        {
            get { return size; }
            set { size = value; }
        }

        public void SetWidth(int w)
        {
            if ( w < 1000 || w > 5000)
            {
                throw new Exception("Podano złe rozmiary kontenera!");

            }
            else
            {
                size.Width = w;
            }
        }
        public void SetHeight(int h)
        {
            if (h > 20000 || h < 5000)
            {
                throw new Exception("Podano złe rozmiary kontenera!");

            }
            else
            {
                size.Height = h;
            }
        }


        public Container(int Height, int Width)
        {
            if (Height > 20000 || Height < 5000 || Width > 1000 || Width < 5000)
            {
                throw new Exception("Podano złe rozmiary kontenera!");
                
            }
            else
            {
                size = new Rectangle(0, 0, Width, Height);//Point reprezentuje lewy góry róg
            }
        }



        public Container()
        {
            size = new Rectangle(0, 0, 2400, 13600);//Rectangle przyjmuje inty takze 1 int = 10 cm 
        }

        public override string ToString()
        {
             return size.Width.ToString() + "x" + size.Height.ToString();
        }

    }
}
