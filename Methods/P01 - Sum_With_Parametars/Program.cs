namespace P01___Sum_With_Parametars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X=");
            double X=double.Parse(Console.ReadLine());
            Console.Write("Y=");
            double Y = double.Parse(Console.ReadLine());

            Sum(X, Y);
        }

        static void Sum(double a,double b)
        {
            Console.WriteLine($"{a+b}");
        }
    }
}
