namespace P10___Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IDrawable circle = new Circle(5.5);
            circle.Draw();

           
            IDrawable rect = new Rectangle(4,5);
            rect.Draw();
        }
    }
}
