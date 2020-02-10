using System;

namespace _1._Generic_Box_of_String
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

            Console.WriteLine(newBox.ToString().TrimEnd());

        }
    }
}
