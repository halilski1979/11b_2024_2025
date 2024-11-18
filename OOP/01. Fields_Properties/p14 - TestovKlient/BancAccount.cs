using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p14___TestovKlient
{
    internal class BancAccount
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

        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        public void Withdraw(double amount)
        {
            this.balance -= amount;
        }

        public override string ToString()
        {
            return $"Account ID{this.id}, balance {this.balance:f2}";
        }

    }
}
