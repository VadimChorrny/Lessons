using System;

namespace Jugged
{
    class Program
    {

        static int[][] CreateJugged(params int[] cols)
        {
            int[][] m = new int[cols.Length][];
            for (int i = 0; i < m.Length; i++)
            {
                m[i] = new int[cols[i]];
            }
            return m;
        }



        static void PrintJuggedArray(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.WriteLine($"{matrix[i][j],-10}");
                }
                Console.WriteLine();
            }
        }
        static int SumJugged(int[][] matrix)
        {
            int sum = 0;
            foreach (int[] line in matrix)
            {
                foreach (int elem in line)
                {
                    sum += elem;
                }
            }
            return sum;

        }
        static int[] SumInRows(int[][] m)
        {
            int[] sum = new int[m.Length];

            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < m[i].Length; j++)
                {
                    sum[i] += m[i][j];
                }
            }
            return sum;
        }
        static void ReverseByRows(int[][] m)
        {
            for (int i = 0, j = m.Length - 1; i < j; j--, i++)
            {
                var tmp = m[i];
                m[i] = m[j];
                m[j] = tmp;
            }
        }
        static void Main(string[] args)
        {
            const int rows = 3;
            int[][] m = new int[rows][]
            {
                new int[4] {1,2,3,4},
                new [] {10,20,30},
                new [] {100,200,1000}
            };
            PrintJuggedArray(m);
            Console.WriteLine($"Sum : {SumJugged(m)}");
            int[][] matrix = CreateJugged(2, 1, 3, 4, 6, 7);
            PrintJuggedArray(matrix);
            ReverseByRows(matrix);
            PrintJuggedArray(matrix);

            Console.WriteLine("_______________");
            //Console.WriteLine($"Sum line : {SumInRows(matrix)}");
            int[] result = SumInRows(m);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            //PrintJuggedArray(matrix);
        }
    }
}
