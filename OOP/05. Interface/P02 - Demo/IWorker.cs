using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02___Demo
{
    internal interface IWorker
    {
        public string JobTitle { get; set; }

        void Work();
    }
}
