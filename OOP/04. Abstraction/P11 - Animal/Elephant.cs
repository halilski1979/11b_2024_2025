using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11___Animal
{
    internal class Elephant:Animal
    {
        
        public Elephant(string name, int age, double weight, string habitat)
            : base(name, age, "Elephant", weight, habitat) { }

       
        public override void MakeSound()
        {
            Console.WriteLine("Trumpet!");
        }
    }
}
