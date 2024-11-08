namespace P08___GetMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int max=NewMax();
            Console.WriteLine(max);
        }

        public static int NewMax()
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                return a;
            }
            else 
            {
                return b;
            }

            //return Math.Max(a, b);
        }
        public static void Max()
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }

            //return Math.Max(a, b);
        }
    }
}
