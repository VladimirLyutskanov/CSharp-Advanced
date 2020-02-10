using System;
using System.Linq;

namespace _5._Generic_Count_Method_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<string> newBox = new Box<string>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                newBox.AddToBox(input);

            }

            string valueToCompare = Console.ReadLine();

            newBox.Compare(valueToCompare);

            int result = newBox.GreaterCount;

            Console.WriteLine(result);
        }
    }
}
