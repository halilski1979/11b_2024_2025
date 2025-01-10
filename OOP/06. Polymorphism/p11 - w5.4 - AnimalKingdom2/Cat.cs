using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11___w5._4___AnimalKingdom2
{
    internal class Cat : IAnimal
    {
        public string MakeNoise()
        {
            return "Meow";
        }

        public string MakeTrick()
        {
            return "No trick for you! I'm too lazy!";
        }

        public void Perform()
        {
            Console.WriteLine(MakeNoise());
            Console.WriteLine(MakeTrick());
        }
    }
}
