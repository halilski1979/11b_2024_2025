using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p15._1___AnimalKingdom
{
    internal class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public override string MakeNoise()
        {
            return $"Meow!";
            return base.MakeNoise();
        }

        public override string MakeTrick()
        {
            return $"No trick for you! I am too lazy!";
        }
    }
}
