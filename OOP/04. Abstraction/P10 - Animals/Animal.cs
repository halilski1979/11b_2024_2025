using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10___Animals
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }

        public Animal(string name, int age, string type)
        {
            Name = name;
            Age = age;
            Type = type;
        }

        public abstract void MakeSound();

        
       
    }
}
