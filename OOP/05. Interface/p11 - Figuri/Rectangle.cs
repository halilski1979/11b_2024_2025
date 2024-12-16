using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11___Figuri
{
    internal class Rectangle : IDrawable
    {
        private double width;
        private double height;

        public Rectangle(double widht, double height)
        {
            Widht = widht;
            Height = height;
        }

        public double Widht
        {
            get { return width; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Shirinata ne moje da bade otricatelno chislo!");
                }

                width = value; 
            }
        }

       

        public double Height
        {
            get { return height; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Visochinata ne moje da bade otricatelno chislo!");
                }
                height = value; 
            }
        }


        public void Draw()
        {
            Console.WriteLine($"Draw rectangle with A={this.Widht} and {this.Height}");
        }
    }
}
