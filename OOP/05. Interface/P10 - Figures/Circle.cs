using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10___Figures
{
    internal class Circle : IDrawable
    {
       public Circle(double radius)
        {
            Radius = radius;
        }

        private double Radius { get; set; }

        public void Draw()
        {
            Console.WriteLine($"I draw Circle with R={this.Radius}");
        }
    }
}
