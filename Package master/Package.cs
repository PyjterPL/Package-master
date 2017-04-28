using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Package_master
{
    class Package
    {
       
        private Rectangle Size { get; set; }

        //konstruktor
        public Package(int Height, int Weight)
        {
            if (Height < 4 || Weight < 4 || Height > 40 || Weight >40)
            {
                throw new Exception("Podano zbyt małe rozmary paczki!!");
            }
            else
            {
                Size = new Rectangle(0, 0, Weight, Height);//Point reprezentuje lewy góry róg
            }
        }
        public Package()
        {
            Size = new Rectangle(0, 0, 12, 8);//Point reprezentuje lewy góry róg
        }
    }
}
