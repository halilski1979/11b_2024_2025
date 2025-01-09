using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15___w4._7___Animals
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
            return "My name is " + name + ". I am " + age + " years old.";
        }

        public virtual string MakeTrick()
        {
            return "Look at my trick!";
        }
    }
}
