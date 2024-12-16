namespace p11___Figuri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDrawable circle = new Circle(3);
            circle.Draw();

            IDrawable rect = new Rectangle(4.5, 3.15);
            rect.Draw();
        }
    }
}
