using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12____Cars
{
    internal class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int batery)
        {
            Model = model;
            Color = color;
            Batery = batery;
        }

        public string Model { get ; set ; }
        public string Color { get ; set ; }
        public int Batery { get ; set ; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{this.Color} Seat {this.Model} with {this.Batery} Bateries";
        }
    }
}
