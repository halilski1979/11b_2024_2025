using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p111___Figures
{
    internal class Rectangle : IDrawable
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }       
        public double Height
        {
            get { return height; }
            set { height = value; }
        }


        public void Draw()
        {
            Console.WriteLine($"I draw rectangle with A={this.Width} and B={this.Height}");
        }
    }
}
