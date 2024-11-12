using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02_AutoProperties
{
    internal class Person
    {

        /*C# предоставя възможност да се използват автоматични свойства, където get и set 
         * автоматично се прилагат върху скрито поле. Това опростява кода и е полезно,
         * когато няма специална логика за get или set */

        public string FName { get; set; }
        public string SName { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
    }
}
