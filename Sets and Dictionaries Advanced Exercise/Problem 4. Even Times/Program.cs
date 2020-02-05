using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < count; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(inputNumber))
                {
                    numbers.Add(inputNumber, 0);
                }
                numbers[inputNumber]++;
            }

            int numberToDisplay = numbers.SingleOrDefault(x => x.Value % 2 == 0).Key;

            Console.WriteLine(numberToDisplay);
        }
    }
}
