using System;
using System.Collections.Generic;

namespace Problem_6._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];

                string[] clothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrobe[color].ContainsKey(clothes[j]))
                    {
                        wardrobe[color].Add(clothes[j], 0);
                    }

                    wardrobe[color][clothes[j]]++;
                }

            }
            string[] clothesToPrint = Console.ReadLine().Split();

            string clothesColor = clothesToPrint[0];
            string cloth = clothesToPrint[1];

            foreach (var dress in wardrobe)
            {

                Console.WriteLine($"{dress.Key}clothes:");

                foreach (var kvp in dress.Value)
                {
                    if (dress.Key==clothesColor && kvp.Key==cloth)
                    {
                        Console.WriteLine($"* {(kvp.Key).Trim()} - {kvp.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {(kvp.Key).Trim()} - {kvp.Value}");
                    }
                    
                }
            }

        }

        

        
    }
}
