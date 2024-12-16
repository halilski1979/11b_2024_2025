using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10___Animals
{
    internal class Parrot:Animal
    {
       
        public Parrot(string name, int age) : base(name, age, "Parrot") 
        { 
        
        }

        
        public override void MakeSound()
        {
            Console.WriteLine("What's up?");
        }
    }
}
