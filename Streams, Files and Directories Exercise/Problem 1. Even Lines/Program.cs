using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem_1._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {

            string filePath = @"../../../text.txt";

            File.ReadAllText(filePath);
            int count = 0;
            using (StreamReader streamreader = new StreamReader(filePath))
            {
                string line = streamreader.ReadLine();
                List<char> reversed = new List<char>();

                while (line != null)
                {
                    if (count %2 ==0)
                    {
                        string replacedSymbols = ReplaceSpecialChars(line);
                        string reversedWords = WordsReversed(replacedSymbols);

                        Console.WriteLine(reversedWords);
                    }
                   
                    count++;
                    line= streamreader.ReadLine();
                }

            }
        }

        private static string WordsReversed(string replacedSymbols)
        {

            return string.Join(" ", replacedSymbols.Split().Reverse());

        }

        private static string ReplaceSpecialChars(string line)
        {
            //"-", ",", ".", "!", "?"} 

           return line.Replace("-", "@").Replace(",", "@").Replace(".", "@").Replace("!", "@").Replace("?", "@");
        }
    }
}
