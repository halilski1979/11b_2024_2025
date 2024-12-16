using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10___Animals
{
    internal class Lion:Animal
    {
        
        public Lion(string name, int age) : base(name, age, "Lion") 
        { 
        }
               

        public override void MakeSound()
        {
            Console.WriteLine("Roar!");
        }
    }
}
