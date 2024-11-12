using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class Person
    {
		
		//Полета
		private string fName;
        private string sName;
        private int age;

		//Свойства
        public string Fname
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


	}
}
