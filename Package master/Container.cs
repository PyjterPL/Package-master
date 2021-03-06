﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Package_master
{
    //Klasa reprezentująca kontener
    class Container
    {       
        private float height;

        public float Height
        {
            get { return height; }
            set
            {
                if (value > 20 || value < 5)
                {
                    throw new Exception("Podano złe rozmiary kontenera!");

                }
                else
                {
                    height = value;
                }
            }
        }
        private float width;

        public float Width
        {
            get { return width; }
            set
            {
                if (value < 1 || value > 5)
                {
                    throw new Exception("Podano złe rozmiary kontenera!");

                }
                else
                {
                    width = value;
                }
            }
        }
        //Konstruktory
        public Container(float Height, float Width)
        {
            if (Height > 20 || Height < 5 || Width > 1 || Width < 5)
            {
                throw new Exception("Podano złe rozmiary kontenera!");

            }
            else
            {
                //size = new Rectangle(0, 0, Width, Height);//Point reprezentuje lewy góry róg
                this.height = Height;
                this.width = Width;

            }
        }



        public Container()
        {
            //size = new Rectangle(0, 0, 2400, 13600);//Rectangle przyjmuje inty takze 1 int = 10 cm 
            this.height = 13.6f;
            this.width = 2.4f;
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

    }
}
