using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01___Demo1
{
    internal interface IWorker
    {
        public string Job { get; set; }
        double Salary(double moneyPerHour,int hours);
    }
}
