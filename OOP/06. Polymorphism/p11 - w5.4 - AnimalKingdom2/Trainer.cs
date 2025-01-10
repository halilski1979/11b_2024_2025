using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11___w5._4___AnimalKingdom2
{
    internal class Trainer
    {
        IAnimal animal;

        public Trainer(IAnimal animal)
        {
            this.animal = animal;
        }

        public void Make()
        {
            animal.Perform();
        }
    }
}
