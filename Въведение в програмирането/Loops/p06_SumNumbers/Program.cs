namespace p06_SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Да се напише програма, която чете n-на брой цели числа, въведени от потребителя и ги сумира.
 От първия ред на входа се въвежда броят числа n.
 От следващите n реда се въвежда по едно цяло число. */

            int n=int.Parse(Console.ReadLine());
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                int num=int.Parse(Console.ReadLine());
                s += num;
            }

            Console.WriteLine(s);





        }


    }
}
