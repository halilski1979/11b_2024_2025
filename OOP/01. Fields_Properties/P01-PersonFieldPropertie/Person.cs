using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_PersonFieldPropertie
{
    internal class Person
    {
		//Поле
		private string fName;
        private string sName;
        private int age;

        //Свойство
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

	}
}
