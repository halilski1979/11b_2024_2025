namespace Demo00
{
    internal class Program
    {
        static void Main(string[] args)
        {
                  
            
            
            Console.Write("Broy hora: ");
            int n=int.Parse(Console.ReadLine());

            //Списък от тип Person 
            List<Person> people = new List<Person>();           

           
            for (int i = 0; i < n; i++)
            {
                //Списък за входни данни за обекта
                var cmd = Console.ReadLine().Split(' ').ToList();

                var fName=cmd[0];
                var sName=cmd[1];
                var age=int.Parse(cmd[2]);
                var salary=double.Parse(cmd[3]);

                //Създаваме обекта чрез конструктор
                Person p = new Person(fName,sName,age,salary);

                //Добавяме обекта към списъка people
                people.Add(p);
            }

            foreach (Person item in people)
            {
                item.Print();
            }





        }
    }
}
