namespace P04_Kvadrat_Ot_Sbor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s=Sum();
            Console.WriteLine(s);
            Console.WriteLine($"{s}^2={Math.Pow(s,2)}");
        }

        static int Sum()
        {
            Console.Write("a=");
            int a=int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            return a + b;
        }
    }
}
