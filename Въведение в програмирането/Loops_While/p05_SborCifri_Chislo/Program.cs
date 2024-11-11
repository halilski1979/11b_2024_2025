namespace p05_SborCifri_Chislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());

            int s = 0;
            while (true)
            {
                s += n % 10;
                n= n / 10;
                if (n == 0) break;
            }
            Console.WriteLine(s);
        }
    }
}
