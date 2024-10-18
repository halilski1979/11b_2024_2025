namespace p08_Vlojeni_Cikli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"i={i}");
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"j={j}");
                }
                Console.WriteLine();
            }
        }
    }
}
