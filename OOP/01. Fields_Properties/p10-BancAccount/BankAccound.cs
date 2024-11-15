using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10_BancAccount
{
    internal class BankAccound
    {
		private int id;
        private double balance;

        public int Id
		{
			get { return id; }
			set { id = value; }
		}

		

		public double Balance
		{
			get { return balance; }
			set { balance = value; }
		}

		public void GetAccount()
		{
            Console.WriteLine($"Account: {Id},balance:{Balance}lv.");
        }
		public void Deposit(double deposit)
		{
			Balance += deposit;
		}
		public void Teglene(double teglene)
		{
		 Balance -= teglene;
		}

	}
}
