using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem_3._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string textPath = "text.txt";
            string wordPath = "words.txt";

            string[] text = File.ReadAllLines(textPath);
            string[] words = File.ReadAllLines(wordPath);

            var wordInfo = new Dictionary<string, int>();

            foreach (var item in words)
            {
                string lowerWord = item.ToLower();
                if (!wordInfo.ContainsKey(lowerWord))
                {
                    wordInfo[lowerWord] = 0;
                }
       
            }
            foreach (var line in text)
            {
                string[] currentWords = line.Split(new char[] {'.', ':',';',',','!','?','-',' '});

                foreach (var currentword in currentWords)
                {
                    string currentToLower = currentword.ToLower();
                    if (wordInfo.ContainsKey(currentToLower))
                    {
                        wordInfo[currentToLower]++;
                    }
                }
            }
            string actualResultPath = "actualResult.txt";
            string expectedlResultPath = "expectedResult.txt";

            foreach (var (key, value) in wordInfo)
            {
                File.AppendAllText(actualResultPath, $"{key} - {value} {Environment.NewLine}");
            }

            foreach (var (key, value) in wordInfo.OrderByDescending(x => x.Value))
            {
                File.AppendAllText(expectedlResultPath, $"{key} - {value} {Environment.NewLine}");
            }
         


        }
    }
}
