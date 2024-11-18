using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace p14___TestovKlient
{
    internal class Client
    {
        Dictionary<int, BancAccount> bankoviSmetki = new Dictionary<int, BancAccount>();

        public void Create(int id)
        {
            if (bankoviSmetki.ContainsKey(id))
            {
                Console.WriteLine("Accounts already exist!");
            }
            else
            {
                var smetka = new BancAccount();
                smetka.Id = id;
                smetka.Balance = 1000;
                //accaount.Balance = 1000;
                bankoviSmetki.Add(id, smetka);

            }
        }
        public void Deposit(int id, double amount)
        {
            if (!bankoviSmetki.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else 
            {
              var smetka =bankoviSmetki[id];
              //BancAccount smetka = bankoviSmetki[id];

                smetka.Deposit(amount);
            }
        }
        public void Withdraw(int id, double amount)
        {
            BancAccount smetka = bankoviSmetki[id];

            if (!bankoviSmetki.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            
            else
            {
                if (smetka.Balance < amount)
                {
                    Console.WriteLine("Insufficient balance");
                   
                }
                else
                {
                    smetka.Withdraw(amount);
                }
            }           

        }
        public void Print(int id)
        {
            if (!bankoviSmetki.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                BancAccount smetka = bankoviSmetki[id];
                Console.WriteLine(smetka.ToString());
            }
        }



    } 

}

