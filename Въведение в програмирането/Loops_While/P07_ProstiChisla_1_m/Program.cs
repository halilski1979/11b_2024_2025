namespace P07_ProstiChisla_1_m
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());

            for (int n = 2; n <= m; n++)
            {
                int ost = 0;

                
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        ost++;
                    }
                }

                
                if (ost == 2)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
