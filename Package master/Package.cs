using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package_master
{
    class Package
    {
        private double Height;//wysokość
        private double Weight;//szerokość

        //konstruktor
        public Package(double Height, double Weight)
        {
            if (Height < 0.1 || Weight < 0.1)
            {
                throw new Exception("Podano zbyt małe rozmary paczki!");
            }
            else
            {
                this.Height = Height;
                this.Weight = Weight;
            }
        }
    }
}
