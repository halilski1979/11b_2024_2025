using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00___Demo
{
    internal interface IPerson
    {
       
        //Само свойства, без полета 
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }

        //Метод без реализация
        void DisplayInfo();
    }
}
