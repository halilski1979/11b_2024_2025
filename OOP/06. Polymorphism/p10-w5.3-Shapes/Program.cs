namespace p10_w5._3_Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shapes> shapes = new List<Shapes>();
            int br = int.Parse(Console.ReadLine());
            for (int i = 0; i < br; i++)
            {
                Console.WriteLine("Choose shape - R for rectangle and C for Circle");
                string type = Console.ReadLine();
                if (type == "R")
                {
                    Console.Write("A = ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("B = ");
                    double b = double.Parse(Console.ReadLine());
                    Shapes shape = new Rectangle(a, b);
                    shapes.Add(shape);
                }
                if (type == "C")
                {
                    Console.Write("R =");
                    double r = double.Parse(Console.ReadLine());
                    Shapes c = new Circle(r);
                    shapes.Add(c);
                }

            }
            foreach (Shapes shape in shapes)
            {
                Console.WriteLine();
                Console.WriteLine(shape.Draw());
                Console.WriteLine(shape.CalculatePerimeter());
                Console.WriteLine(shape.CalculateArea());
                
                
            }
        }
    }
}
