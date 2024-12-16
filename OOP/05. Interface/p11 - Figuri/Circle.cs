using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11___Figuri
{
    internal class Circle : IDrawable
    {

        private double radius;

        public Circle(double radius)
        {
           Radius = radius;
        }

        public double Radius
        {
            get { return radius; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Radius ne moje da bade otricatelno chislo!");
                }
                radius = value; 
            }
        }


        public void Draw()
        {
            Console.WriteLine($"Draw circle with radius R={this.Radius}");
        }
    }
}
