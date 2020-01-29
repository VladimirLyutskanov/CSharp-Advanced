using System;
using System.Collections.Generic;

namespace _8.__Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> brackets = new Stack<char>();
            char[] input = Console.ReadLine().ToCharArray();
            bool isValid = true;
            

            foreach (var item in input)
            {
                if (item == '(' || item == '[' || item == '{')
                {
                    brackets.Push(item);
                    continue;                
                }
                if (brackets.Count==0)
                {
                    isValid = false;
                    break;
                }
               
                if (brackets.Peek()=='(' && item==')')
                {
                    brackets.Pop();
                }
                else if (brackets.Peek() == '[' && item == ']')
                {
                    brackets.Pop();
                }
                else if (brackets.Peek() == '{' && item == '}')
                {
                    brackets.Pop();
                }
                else
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
               
                 Console.WriteLine("YES");

            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
