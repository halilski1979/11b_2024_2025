using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p111___Figures
{
    internal class Circlee : IDrawable,IArea
    {

        private double radius;

        public Circlee(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double CalculateArea()
        {
            return Math.PI * Radius*Radius;
        }

        public void Draw()
        {
            Console.WriteLine($"I draw circle with R={this.Radius}");
        }
    }
}
