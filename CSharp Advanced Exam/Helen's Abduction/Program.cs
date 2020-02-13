using System;

namespace Helen_s_Abduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int parisHealh = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            char[][] matrix = new char[rows][];

            int prow = 0;
            int pcol = 0;

            int enemyrow = 0;
            int enemycol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] columns = Console.ReadLine().ToCharArray();

                matrix[row] = columns;

                for (int col = 0; col < columns.Length; col++)
                {
                    matrix[row][col] = columns[col];

                    if (matrix[row][col] == 'P')
                    {
                        prow = row;
                        pcol = col;

                    }
                }
            }

            while (true)
            {
                //up 3 0

                string[] indexes = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string parisMove =indexes[0];

                enemyrow = int.Parse(indexes[1]);
                enemycol = int.Parse(indexes[2]);

                matrix[enemyrow][enemycol] = 'S';

                if (parisMove=="up")
                {
                    if (prow - 1 >= 0)
                    {
                        if (matrix[prow - 1][pcol] == 'H')
                        {
                            matrix[prow - 1][pcol] = '-';
                            matrix[prow][pcol] = '-';
                            parisHealh -= 1;
                            Console.WriteLine("Paris has successfully abducted Helen!");
                            Console.WriteLine($"Energy left: {parisHealh}");
                            break;
                        }

                        if (matrix[prow - 1][pcol] == 'S')
                        {
                            matrix[prow - 1][pcol] = 'P';
                            matrix[prow][pcol] = '-';
                            parisHealh -= 2;
                        }
                        else
                        {
                            matrix[prow - 1][pcol] = 'P';
                            matrix[prow][pcol] = '-';
                            parisHealh -= 1;
                        }
                    } 
                    else
                    {
                        parisHealh -= 1;
                    }
                    prow--;
                    if (parisHealh <= 0)
                    {
                        matrix[prow-1][pcol] = 'X';
                        return;
                    }
                }
            }
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }

        }
    }
}
