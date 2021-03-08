using System;
using System.Linq;

namespace Matrix
{
    class Program
    {
        static void FillRand(int [,] m,int left = 1, int right = 100 )
        {
            Random random = new Random();
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = random.Next(left, right + 1);
                }
            }
        }
        static void PrintMatrix(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++) // GetLength() = число рядків
            {
                for (int j = 0; j < m.GetLongLength(1); j++)
                {
                    Console.WriteLine($"{m[i, j]}\t");
                }
            }
        }

        static int MaxInMatrix(int[,] m)
        {
            int max = m[0,0];
            foreach (var item in m)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }
        static void Main(string[] args)
        {
            const int ROW = 2, COLS = 3;
            int[,] matrix = new int[ROW, COLS]
            { // start init
                {1,2,3 },
                {10,20,30 }
            };
            FillRand(matrix);
            PrintMatrix(matrix);
            Console.WriteLine($"Max value : {MaxInMatrix(matrix)}");

        }
    }
}
