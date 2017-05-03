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
            return size.Width + "x" + size.Height;
        }

        private int field;

        public int Field
        {
            get { return field; }  //set { field = value; }
        }


        //konstruktor
        public Package(int Height, int Width)
        {
            if (Height < 40 || Width < 40 || Height > 400 || Width >400)
            {
                throw new Exception("Podano zbyt małe rozmary paczki!!");
            }
            else
            {
                size = new Rectangle(0, 0, Width, Height);//Point reprezentuje lewy góry róg
                field = Width * Height;
            }
        }
        public Package()
        {
            size = new Rectangle(0, 0, 120, 80);//Point reprezentuje lewy góry róg
            field = 120 * 80;
        }
    }
}
