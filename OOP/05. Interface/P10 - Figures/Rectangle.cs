using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10___Figures
{
    internal class Rectangle : IDrawable
    {
        private double StranaA { get; set; }
        private double StranaB { get; set; }
        public Rectangle(double stranaA, double stranaB)
        {
            StranaA = stranaA;
            StranaB = stranaB;
        }

      
        public void Draw()
        {
            Console.WriteLine($"I draw Rectangle with A={this.StranaA} and B={this.StranaB}"); ;
        }
    }
}
