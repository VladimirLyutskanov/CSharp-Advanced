namespace _9.__Simple_Text_Editor
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
       public static void Main(string[] args)
        {
            Stack<string> symbols = new Stack<string>();
            string text = string.Empty;

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0]=="1")
                {
                    symbols.Push(text);
                    text += input[1];
                }
                else if (input[0]=="2")
                {
                    int index = int.Parse(input[1]);
                    symbols.Push(text);
                    text = text.Substring(0, text.Length - index);
                }
                else if(input[0] == "3")
                {
                    int index = int.Parse(input[1]);
                    Console.WriteLine(text[index-1]);
                }
                else if (input[0] == "4")
                {
                    text = symbols.Pop();
                }
            }
           
        }
    }
}
