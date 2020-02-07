using System;

namespace Problem_1._Define_a_Class_Person
{
    class StartUp

    {
        static void Main(string[] args)
        {
            Person person = new Person(10, "Peter");
            Person person1 = new Person(12, "Ivan");
            Person person2 = new Person(20, "Chocho");
            Person person3 = new Person(20, "Ahocho");

            Family family = new Family();
            family.AddMember(person);
            family.AddMember(person1);
            family.AddMember(person2);
            family.AddMember(person3);
            Console.WriteLine(person +"-----");
            family.PrintMembers();

            Console.WriteLine(family.GetOldestMember().Name);


          
        }

     
    }
}
