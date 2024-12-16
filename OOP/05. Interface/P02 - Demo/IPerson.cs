using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02___Demo
{
    internal interface IPerson
    {
        public string FName { get; set; }
        public string SName { get; set; }
        public int Age { get; set; }

        public void DisplayInfo();

    }
}
