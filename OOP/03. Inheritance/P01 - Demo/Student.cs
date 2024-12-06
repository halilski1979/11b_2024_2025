using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01___Demo
{
    internal class Student : Person
    {
        private string fNomer;

        public string FNomer
        {
            get { return fNomer; }
            set { fNomer = value; }
        }


        public Student(string fName, string sName, int age, string fnomer) : base(fName, sName, age)
        {
            this.FNomer = fnomer;
        }

        public override void DisplayInfo()
        {
            
            Console.WriteLine($"Kazvam se {this.FName} {this.SName}. Az sam na {this.Age} godini! Moqt nomer e {this.FNomer}!");
        }
    }
}
