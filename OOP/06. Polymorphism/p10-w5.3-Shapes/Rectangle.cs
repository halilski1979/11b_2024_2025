using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10_w5._3_Shapes
{
    internal class Rectangle:Shapes
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; private set; }
        public double Height { get; private set; }

        public override double CalculateArea()
        {
            double area = Width * Height;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double p = 2 * Width + 2 * Height;
            return p;
        }
        public override string Draw()
        {
            return $"Draw a rectangle with A = {this.Width} and B = {this.Height}";
        }
    }
}
