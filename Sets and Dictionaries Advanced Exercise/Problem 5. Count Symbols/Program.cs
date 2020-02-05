using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> symbols = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];

                if (!symbols.ContainsKey(currentSymbol))
                {
                    symbols.Add(currentSymbol, 0);
                }
                symbols[currentSymbol]++;
            }

            foreach (var item in symbols.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
