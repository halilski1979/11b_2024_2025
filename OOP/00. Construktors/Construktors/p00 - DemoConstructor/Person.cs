using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace p00___DemoConstructor
{
    internal class Person
    {
		private string fName;
        private string sName;
        private int age;
        private double salary;

        public Person(string fName, string sName, int age, double salary)
        {
            this.FName = fName;
            this.SName = sName;
            this.Age = age;
            this.Salary = salary;
        }

		public Person()
		{

		}

		public Person(string fName,string sName)
		{
			this.FName = fName;
			this.SName = sName;
		}

		public Person(string ime,string familia, int godini)
		{
			this.FName= ime;
			this.SName= familia;
			this.Age = godini;
		}

        public string FName
		{
			get { return fName; }
			set { fName = value; }
		}		
		public string SName
		{
			get { return sName; }
			set { sName = value; }
		}		
		public int Age
		{
			get { return age; }
			set { age = value; }
		}		
		public double Salary
		{
			get { return salary; }
			set { salary = value; }
		}


		//Пренаписваме метода ToString()
        public override string ToString()
        {
            return $"My name is {FName} {SName}. I am {Age} years odl." +
				$"My salary is {Salary} lv. ";	
        }




    }
}
