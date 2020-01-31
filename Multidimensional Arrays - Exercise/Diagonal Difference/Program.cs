using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            //Primary diagonal:
            int primarySum = 0;

            for (int row = 0; row < n; row++)
            {
                primarySum += matrix[row][row];
            }

            //Secondary diagonal:
            long secondarySum = 0;

            for (int row = 0, col = n - 1; row < n; row++, col--)
            {
                secondarySum += matrix[row][col];
            }

            Console.WriteLine(Math.Abs(primarySum - secondarySum));
        }
    }
}
