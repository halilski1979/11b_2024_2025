using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p16___Family
{
    internal class Family
    {
        public List<Person> persons = new List<Person>();
        public void AddMember(Person member)
        {
            persons.Add(member);
        }
        public void Print()
        {
            foreach (Person person in persons)
            {
                Console.WriteLine();
                Console.WriteLine($"My name is {person.Name}, {person.Age} years old.");
            }
        }
        public void SortName()
        {
            persons = persons.OrderBy(x => x.Name).ToList();
        }

        public Person GetOldestMember()
        {            
            return persons.OrderBy(x => x.Age).LastOrDefault();
        }
    }
}
