namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Просто число
            int n = int.Parse(Console.ReadLine());
            int ost = 0;

            for (int i = 1; i <= n; i++)
            {
                // Проверяваме дали n се дели на i без остатък
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
