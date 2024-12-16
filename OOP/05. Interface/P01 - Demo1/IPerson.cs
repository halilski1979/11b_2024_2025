using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01___Demo1
{
   internal interface IPerson
    {
        public string FName { get; set; }
        public string SName { get; set; }
        public int Age { get; set; }

        public void GetInfo();


    }
}
