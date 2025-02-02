﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p100___TestovKlient
{
    internal class Client
    {
        Dictionary<int,BancAccount> bankoviSmetki=new Dictionary<int,BancAccount>();

        public void Create(int id)
        {
            if (bankoviSmetki.ContainsKey(id))
            {
                Console.WriteLine("Account exist!");
            }
            else
            {
                BancAccount smetka=new BancAccount();
                smetka.Id = id;              
                bankoviSmetki.Add(id, smetka);
            }
        }

        public void Deposit(int id, double amount)
        {
            if (!bankoviSmetki.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist.");
            }
            else
            {
                BancAccount smetka = bankoviSmetki[id];
                smetka.Deposit(amount);
            }
        }

        public void Withdraw(int id, double amount)
        {
            BancAccount smetka= bankoviSmetki[id];

            if (!bankoviSmetki.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist.");
            }
            else
            {
                if (smetka.Balance<amount)
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
                Console.WriteLine("Account does not exist.");
            }
            else
            {
                BancAccount smetka = bankoviSmetki[id];
                Console.WriteLine(smetka.ToString());
            }
        }




    }
}
