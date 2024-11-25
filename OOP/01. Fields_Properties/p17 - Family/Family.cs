using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p17___Family
{
    internal class Family
    {
        //Списък от хора
        List<Person> persons=new List<Person>();

        
        //Добавя член на фамилията
        public void AddMember(Person member)
        {
            persons.Add(member);
        }
        
        //Връща най-възрастният член на фамилията
        public Person GetOldestMember()
        {
            return persons.OrderBy(x => x.Age).LastOrDefault();
        }

    }
}
