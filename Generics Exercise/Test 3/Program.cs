using System;
using System.Linq;

namespace Test_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Box <string> newBox = new Box<string>(); 
           

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                newBox.AddToBox(input);

            }

            int[] indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            newBox.Swap(firstIndex, secondIndex);

            Console.WriteLine(newBox.ToString().TrimEnd());
        }
    }
}
