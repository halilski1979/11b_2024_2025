using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p15._1___AnimalKingdom
{
    internal class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public override string MakeNoise()
        {
            return $"Woof";
            return base.MakeNoise();
        }

        public override string MakeTrick()
        {
            return $"Hold my paw, human!";
        }
    }
}
