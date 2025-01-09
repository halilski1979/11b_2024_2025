﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15___w4._7___Animals
{
    internal class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }
        public virtual void MakeNoise()
        {
            Console.WriteLine("Meow!");
            base.MakeNoise();
        }

        public virtual void MakeTrick()
        {
            Console.WriteLine("No trick for you! I'm too lazy!");
        }
    }
}
