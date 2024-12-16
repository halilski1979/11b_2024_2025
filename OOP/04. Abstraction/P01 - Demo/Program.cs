namespace P01___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Person p= new Person("Ivan","Ivanov",24);
           Student s=new Student("Ivan", "Ivanov", 24,5.50);
           
           s.GetName();
           s.GetFullInfo();
        }
    }
}
