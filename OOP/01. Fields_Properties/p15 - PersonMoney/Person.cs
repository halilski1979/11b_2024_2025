using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p15___PersonMoney
{
    internal class Person
    {
		private string name;
        private int age;
        public string Name		
		{
			get { return name; }
			set { name = value; }
		}	
		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		private List<BankAccount>  accounts=new List<BankAccount>();

		public List<BankAccount>  Accounts
		{
			get { return accounts; }
			set { accounts= value; }
		}


		public double GetBalance()
		{
			double allMoney = 0;
			foreach (BankAccount account in accounts)
			{
				allMoney += account.Balance;
			}
			return allMoney;

			//2 начин
			//return accounts.Sum(x => x.Balance);
		}
	}
}
