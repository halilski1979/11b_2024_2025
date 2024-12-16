using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11___Animal
{
    internal class Lion:Animal
    {
       
        public Lion(string name, int age, double weight, string habitat)
            : base(name, age, "Lion", weight, habitat) 
        {
        
        }

        
        public override void MakeSound()
        {
            Console.WriteLine("Roar!");
        }
    }
}
