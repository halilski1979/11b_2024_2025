namespace p10___Stepen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int osnova=int.Parse(Console.ReadLine());
            int stepen=int.Parse(Console.ReadLine());

            double result=Stepenn(osnova, stepen);
            Console.WriteLine(result);
        }

        static double Stepen(double osn,double ste)
        {
            return Math.Pow(osn,ste);
        }

        static double Stepenn(double osn, double ste)
        {
            double res = 1;
            for (int i = 0; i <= osn; i++)
            {
                res *= osn;
            }
            return res;
        }
    }
}
