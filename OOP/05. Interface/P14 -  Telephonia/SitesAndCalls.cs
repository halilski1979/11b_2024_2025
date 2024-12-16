using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14____Telephonia
{
    internal class SitesAndCalls : ICall, IBrowse
    {
        public void Browse(string[] sites)
        {
            for (int i = 0; i < sites.Length; i++)
                if (sites[i].Any(a => char.IsNumber(a)))
                    Console.WriteLine("Invalid URL!");
                else
                    Console.WriteLine("Browsing: " + sites[i]);
        }

        public void Call(string[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (ulong.TryParse(numbers[i], out ulong useless))
                    Console.WriteLine("Calling... " + numbers[i]);
                else
                    Console.WriteLine("Invalid number!");
            }
        }
    }
}
