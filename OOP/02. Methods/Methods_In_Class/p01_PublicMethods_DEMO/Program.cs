namespace p01_PublicMethods_DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ivan", "Ivanov", 20);

            // Извличане на пълното име
            string fullName = person.GetFullName();
            Console.WriteLine(fullName); // Извежда: Ivan Ivanov

            // Проверка дали е пълнолетен
            bool isAdult = person.IsAdult();
            Console.WriteLine(isAdult); // Извежда: True

            // Увеличаване на възрастта
            person.IncreaseAge();
            Console.WriteLine(person.Age); // Извежда: 21

        }
    }
}
