using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p20___Shapes
{
    internal class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get;private set; }
        public override double CalculateArea()
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override string Draw()
        {
            return $"Draw a circle with R = {this.Radius}";
        }
    }
}
