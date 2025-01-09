using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p14___Employee
{
    internal class ContractEmployee : BaseEmployee
    {
        public string employeeTask { get;private set; }
        public string employeeDepartment { get;private set; }
        public ContractEmployee(string employeeID, string employeeName, string employeeAddress,string employeeTask,string employeeDepartment) : base(employeeID, employeeName, employeeAddress)
        {
            this.employeeTask = employeeTask;
            this.employeeDepartment = employeeDepartment;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Task: {this.employeeTask}");
            Console.WriteLine($"Otdel: {this.employeeDepartment}");
        }
        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 20;
        }

        public override string GetDepartment()
        {
            return employeeDepartment;
        }
    }
}
