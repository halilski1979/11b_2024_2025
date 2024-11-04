namespace P03_ZnakChislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Number();
           int num=int.Parse(Console.ReadLine());
            Number(num);

        }

        private static void Number()
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine($"The number {n} = 0");
            }
            else if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive");
            }
            else
            {
                Console.WriteLine($"The number {n} is negative");
            }
        }
        private static void Number(int n)
        {            

            if (n == 0)
            {
                Console.WriteLine($"The number {n} = 0");
            }
            else if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive");
            }
            else
            {
                Console.WriteLine($"The number {n} is negative");
            }
        }
    }
}
