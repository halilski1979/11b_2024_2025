using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p15._1___AnimalKingdom
{
    public abstract class Animal : IMakeNoise, IMakeTrick
    {
        public string name;
        public int age;

        protected Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual string MakeNoise()
        {
            return $"My name is {this.name}. I am {this.age} old.";
        }

        public virtual string MakeTrick()
        {
            return $"Look at my trick!";
        }
    }
}
