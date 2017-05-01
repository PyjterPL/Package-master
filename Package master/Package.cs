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

        private Rectangle size;
        public Rectangle Size
        {
            get { return size; }
            set { size = value; }
        }

        public override string ToString()
        {
            return size.Width + " x" + size.Height;
        }

        //konstruktor
        public Package(int Height, int Weight)
        {
            if (Height < 40 || Weight < 40 || Height > 400 || Weight >400)
            {
                throw new Exception("Podano zbyt małe rozmary paczki!!");
            }
            else
            {
                size = new Rectangle(0, 0, Weight, Height);//Point reprezentuje lewy góry róg
            }
        }
        public Package()
        {
            size = new Rectangle(0, 0, 120, 80);//Point reprezentuje lewy góry róg
        }
    }
}
