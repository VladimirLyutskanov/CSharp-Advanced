using System;
using System.Collections.Generic;

namespace Sets_and_Dictionaries_Advanced_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                names.Add(input);
            }

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
