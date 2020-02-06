using System;
using System.IO;
using System.Linq;


namespace Problem_2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string textPath = @"text.txt";
            string outputPath = @"output.txt";

            string [] lines  = File.ReadAllLines(textPath);
            int counter = 1;
            foreach (var line in lines)
            {
                //Line 1: -I was quick to judge him, but it wasn't his fault. (37)(4)
                int letterCount = line.Count(char.IsLetter);
                int punstCount = line.Count(char.IsPunctuation);
               
                File.AppendAllText(outputPath, $"Line {counter}: {line} ({letterCount})({punstCount}){Environment.NewLine}");

                counter++;
            }
           
        }
    }
}
