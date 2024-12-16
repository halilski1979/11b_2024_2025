using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p13___Employee
{
    internal class ContractEmployee : BaseEmployee
    {

       //imutabble -поле
        
        public string employeeTask { get;private set; }
        public string employeeDepartment { get;private set; }

        public ContractEmployee(string employeeID, string employeeName, string employeeAdress, string employeeTask, string employeeDepartment) : base(employeeID, employeeName, employeeAdress)
        {
            this.employeeTask = employeeTask;
            this.employeeDepartment = employeeDepartment;
        }

      
        
        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 20;
        }



        public override string GetDepartment()
        {
           return employeeDepartment;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Task: {employeeTask}");
        }
    }
}
