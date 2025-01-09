namespace p111___Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circlee c=new Circlee(4.5);
            c.Draw();
            Console.WriteLine($"Area is :{c.CalculateArea():f2}");

            Rectangle r = new Rectangle(3,4.5);
            r.Draw();
        }
    }
}
