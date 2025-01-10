using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11___w5._4___AnimalKingdom2
{
    internal interface IAnimal:IMakeNoise,IMakeTrick
    {
        void Perform();

    }
}
