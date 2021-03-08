using System;
using System.Collections;

namespace Movies
{
    class Program
    {
        static void Main(string[] args)
        {

            // for input size arrays
            Console.WriteLine("Enter count that add films : ");
            int SIZE = int.Parse(Console.ReadLine());

            // init arrays
            String[] films = new String[SIZE];

            // cycle for input films
            Console.Clear();
            Console.WriteLine("Enter your favorite films : ");
            for (int i = 0; i < SIZE; i++)
            {
                films[i] = Console.ReadLine();
            }
            // cycle for output your films
            Console.Clear();
            Console.WriteLine($"Your favorite films... :D");
            for (int i = 0; i < SIZE; i++)
            {
                // add point
                int point = i + 1;
                Console.WriteLine($"{point}. Film - {films[i]}");
            }

            // alphabeting sort
            Console.WriteLine("After sorting films : ");
            
            Array.Sort(films);
            for (int i = 0; i < SIZE; i++)
            {
                Console.WriteLine(films[i]);
            }
        }
    }
}
