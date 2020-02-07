using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Problem_1._Define_a_Class_Person
{
    class Family
    {
        private List<Person> familyMembers;

        public Family()
        {
            familyMembers = new List<Person>();
        }

        public void AddMember (Person member)
        {
            familyMembers.Add(member);
        }

        public void PrintMembers()
        {
            foreach (var item in familyMembers.OrderByDescending(x => x.Age).ThenBy(n => n.Name))
            {
                Console.WriteLine($"{item.Name} is {item.Age} years old ");
            }
        }

        public Person GetOldestMember()
        {
            Person oldestperson =  familyMembers.OrderByDescending(m => m.Age).FirstOrDefault();
            return oldestperson;
        }

     
    }
}
