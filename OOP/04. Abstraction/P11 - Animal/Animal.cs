using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11___Animal
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }
        public double Weight { get; set; }
        public string Habitat { get; set; }     
       

        
        public Animal(string name, int age, string type, double weight, string habitat)
        {
            Name = name;
            Age = age;
            Type = type;
            Weight = weight;
            Habitat = habitat;
        }

        
        public void Feed()
        {
            Console.WriteLine($"{Name} is eating.");
        }        
        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
        public abstract void MakeSound();
    }
}
