using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02___Demo2
{
    internal class STudent : Person
    {

        public double Grade { get; set; }

        public STudent(string fName, string sName, int age, double grade) : base(fName, sName, age)
        {
            this.Grade = grade;
        }

        public override void FullInfo()
        {
            Console.WriteLine($"My name is {this.FName} {this.SName}. My grade is {this.Grade}"); 
        }
    }
}
