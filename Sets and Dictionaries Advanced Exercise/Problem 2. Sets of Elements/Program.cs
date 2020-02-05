using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numerOne = numbersInput[0];
            int numberTwo = numbersInput[1];
           

            HashSet<int> firstNumbers = new HashSet<int>();
            HashSet<int> secondNumbers = new HashSet<int>();

            for (int i = 0; i < numerOne; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                firstNumbers.Add(inputNumber);     

            }

            for (int i = 0; i < numberTwo; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                secondNumbers.Add(inputNumber);       

            }

            foreach (var item in firstNumbers)
            {
                if (secondNumbers.Contains(item))
                {
                    Console.Write(item + " ");
                }
               
            }
           
     


        }
    }
}
