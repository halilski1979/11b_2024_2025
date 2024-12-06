namespace P14___Humans_Matura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Създаваме списък от Human
            List<Human> listHuman = new List<Human>();

            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("First name: ");
                string ime = Console.ReadLine();
                Console.Write("Last name: ");
                string familia = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Your choice[s - student] , [w - worker]: ");
                string sw = Console.ReadLine();
                if (sw == "s")
                {
                    Console.Write("Grade: ");
                    double ocenka = double.Parse(Console.ReadLine());
                    Student s=new Student(ime,familia,age,ocenka);

                    listHuman.Add(s);
                }

                if (sw == "w")
                {
                    Console.Write("Wage: ");
                    double nadnik = double.Parse(Console.ReadLine());
                    Console.Write("workHours: ");
                    int chasove=int.Parse(Console.ReadLine());

                    Worker rabotnik = new Worker(ime,familia,age,nadnik,chasove);
                    listHuman.Add(rabotnik);
                }
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(listHuman[i]);
            }
        }
    }
}