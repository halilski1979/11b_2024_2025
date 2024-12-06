namespace P01___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Person p=new Person("Ivan","Ivanov",24);

          
           p.DisplayInfo();

            Student s = new Student("Petar","Petrov",24,"N111");
            s.DisplayInfo();

        }
    }
}
