using System;

namespace Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rows][];
            int leftSum = 0;

            for (int i = 0; i < jagged.GetLength(0); i++)
            {

                int[] inputnumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < jagged.GetLength(1); j++)
                {
                    jagged[i][j] = inputnumbers[j];
                }


            }

            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join(" ", item));
            }
            for (int row = 0; row < jagged.GetLength(0); row++)
            {

                for (int col = 0; col < jagged.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        leftSum += jagged[row][col];
                    }
                }
            }

            Console.WriteLine(leftSum);
        }
    }
}
