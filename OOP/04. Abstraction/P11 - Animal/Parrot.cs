using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11___Animal
{
    internal class Parrot:Animal
    {
        // Конструктор на Parrot, който използва конструктора на базовия клас
        public Parrot(string name, int age, double weight, string habitat)
            : base(name, age, "Parrot", weight, habitat) { }

        // Имплементация на абстрактния метод
        public override void MakeSound()
        {
            Console.WriteLine("What's up?");
        }
    }
}
