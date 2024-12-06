using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01___Demo
{
    internal class Person
    {
		private string fName;
        private string sName;
        private int age;

        public Person(string fName, string sName, int age)
        {
            
			//Да минава пре свойство
			this.FName = fName;
            this.SName = sName;
            this.Age = age;
        }

        public string FName
		{
			get { return fName; }
			private set 
			{ 
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentNullException("Prazen niz");
				}
				if (value.Length < 3)
				{
					throw new ArgumentException("Imeto e po-malko ot 3 simvola");
				}

				fName = value; 
			}
		}	

		public string SName
		{
			get { return sName; }
			private set 
			{
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Prazen niz");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("Prezimeto e po-malko ot 3 simvola");
                }

                sName = value; 
			}
		}		
				
		public int Age
		{
			get { return age; }
			private set 
			{
				if (value<0)
				{
					throw new ArgumentException("Godinite ne mogat da sa otricatelno chisloi!");
				}
				age = value; 
			}
		}

        public override string ToString()
        {
            return $"My name is {this.FName} {this.SName}. I am {this.Age} years old!";
        }

		public virtual void DisplayInfo()
		{
            Console.WriteLine($"Kazvam se {this.FName} {this.SName}. Az sam na {this.Age} godini!");
		}

    }
}
