using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00___Demo
{
    internal interface IWorker
    {
        string JobTitle { get; set; }
        void Work();
    }
}
