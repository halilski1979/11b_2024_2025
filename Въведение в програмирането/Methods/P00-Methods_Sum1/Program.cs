namespace P00_Methods_Sum1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum();
        }

        
        //Метод за събиране на 2 числа без параметри
        static void Sum()
        {
            Console.Write("a=");
            double a=double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());

            double s = a + b;
            Console.WriteLine($"{a} + {b} = {s}");
        }
    }
}
