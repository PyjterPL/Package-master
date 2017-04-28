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

        private Rectangle Size { get; set; }

        public Container(int Height, int Weight)
        {
            if (Height > 200 || Height < 50 || Weight > 5 || Weight < 1)
            {
                throw new Exception("Podano złe rozmiary kontenera!");
                
            }
            else
            {
                Size = new Rectangle(0, 0, Weight, Height);//Point reprezentuje lewy góry róg
            }
        }



        public Container()
        {
            Size = new Rectangle(0, 0, 24, 136);//Rectangle przyjmuje inty takze 1 int = 10 cm 
        }

    }
}
