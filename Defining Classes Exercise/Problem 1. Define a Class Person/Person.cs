using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_1._Define_a_Class_Person
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person()
        {
            Name = "No name";
            Age = 1;
        }
        public Person(int age) : this ()
        {
            Age = age;
        }

        public Person(int age, string name) : this(age)
        {
            Name = name;
        }

        public override string ToString()
        {
            string man = $"The age is {Age}, and the name is {Name}";
            return man;
        }


    }
}
