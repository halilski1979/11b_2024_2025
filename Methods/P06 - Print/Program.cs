namespace P06___Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print();
            Console.WriteLine();

            int number = int.Parse(Console.ReadLine());
            Pechat(number);
        }

        private static void Print()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Pechat(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
