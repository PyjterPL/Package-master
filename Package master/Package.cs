using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Package_master
{
    class Package : IComparable
    {

       // private Rectangle size;
        //public Rectangle Size
       // {
       //     get { return size; }
       //     set { size = value; }
      //  }

        private float width;

        public float Width
        {
            get { return width; }
           // set { width = value; }
        }

        private float height;

        public float Height
        {
            get { return height; }
            //set { height = value; }
        }

        public float Widht_100()
        {
            return width * 100;
        }
        public float Height_100()
        {
            return height * 100;
        }


        public override string ToString()
        {
            return width.ToString() + "x" + height.ToString();
        }

        public int CompareTo(object obj)
        {
            Package that = (Package)obj;
            //throw new NotImplementedException();
            if (this.height == that.height) return 0;
            if (this.height > that.height) return -1;
            return 1;
            
        }

        private float field;

        public float Field
        {
            get { return field; }  //set { field = value; }
        }

        //comp

        //konstruktory
        public Package(float Height, float Width)
        {
            if (Height < 0.4 || Width < 0.4 || Height > 4 || Width > 4 )
            {
                throw new Exception("Podano złe rozmary paczki!!");
            }
            else
            {
                //size = new Rectangle(0, 0, Width, Height);//Point reprezentuje lewy góry róg
                this.width = Width;
                this.height = Height;
                field = Width * Height;
            }
        }
        public Package()
        {
            //size = new Rectangle(0, 0, 120, 80);//Point reprezentuje lewy góry róg
            width = 0.8f;
            height = 1.2f;
            field = 0.8f * 1.2f;
        }
    }
}
