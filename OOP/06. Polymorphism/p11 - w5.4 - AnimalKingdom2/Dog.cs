using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11___w5._4___AnimalKingdom2
{
    internal class Dog : IAnimal
    {
        public string MakeNoise()
        {
            return "Baouf";
        }

        public string MakeTrick()
        {
            return "Hold my paw, human!";
        }

        public void Perform()
        {
            Console.WriteLine(MakeNoise());
            Console.WriteLine(MakeTrick());
        }
    }
}
