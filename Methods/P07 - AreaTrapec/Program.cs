namespace P07___AreaTrapec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double sTr = LiceTrapec1(a,b,h);
            Console.WriteLine(sTr);
        }

        static void Area()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double s = ((a + b) / 2) * h;
            Console.WriteLine(s);
        }
        static void LiceTrapec(double a,double b, double h)
        {
            double s = ((a + b) / 2) * h;
            Console.WriteLine(s);
        }

        static double Area1()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double s = ((a + b) / 2) * h;
            return (s);
        }
        static double LiceTrapec1(double a, double b, double h)
        {
            double s = ((a + b) / 2) * h;
            return (s);
        }
    }
}
