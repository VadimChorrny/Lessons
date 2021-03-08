using System;

namespace Lessons
{
    class Program
    {
        static void TestRandom()
        {
            Random random = new Random();
            int id = random.Next();
            Console.WriteLine(id);
        }

        static void TestConsole()
        {
            ConsoleColor color = 0;

        }
        static void TestArray()
        {
            int[,] array = new int[5, 5]; // двомірний масив
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"Output ... {array[i, j]}");
                }
            }

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($"Your number index {i}, is {array[i, i]}");
            //}
            //int[,,] array1 = new int[10,10, 10]; // трьохмірний масив
            //int[,,,] array2 = new int[10,10, 10,10]; // чотирьохмірний масив
        }
        static void Main(string[] args)
        {
            //TestArray();


        }
    }
}
