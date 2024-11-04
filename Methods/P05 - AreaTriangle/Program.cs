namespace P05___AreaTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a=double.Parse(Console.ReadLine());
            Console.Write("ha=");
            double ha=double.Parse(Console.ReadLine());

            Console.WriteLine(AreaTr(a,ha));

        }

        //Лице на триъгълник
        static double AreaTr(double a,double ha)
        {
            return (a * ha) / 2;
        }
    }
}
