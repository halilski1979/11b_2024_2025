namespace p06_ProstiChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
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
                Console.WriteLine("Prosto");
            }
            else
            {
                Console.WriteLine("NE");
            }
        }
    }
}
