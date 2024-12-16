namespace P00___DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Създаване на обекти - I начин
            Person person = new Person("John", "Doe", 30);
            Student student = new Student("Alice", "Smith", 20, "A");
            Teacher teacher = new Teacher("Bob", "Brown", 45, "Mathematics");

            // Извикване на методи
            person.DisplayInfo();
            Console.WriteLine();

            student.DisplayInfo();
            Console.WriteLine();

            teacher.DisplayInfo();

            Console.WriteLine();
            Console.WriteLine(new string('*',80));
            Console.WriteLine();

            // Създаване на обекти - II начин
            Person person1 = new Person("Hristo", "Stoichkov", 130);
            Person student1 = new Student("Blez", "Pascal", 120, "A");
            Person teacher1 = new Teacher("TeacherName", "TeacherLastName", 145, "Mathematics");

            // Извикване на методи
            person1.DisplayInfo();
            Console.WriteLine();

            student1.DisplayInfo();
            Console.WriteLine();

            teacher1.DisplayInfo();


        }
    }
}
