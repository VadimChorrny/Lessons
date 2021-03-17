using System;

namespace Tuple_
{
    class Program
    {
        static void Main(string[] args)
        {
            //var t = ("Vadim", 15, "C#");
            //t.Item2 += 20;
            //t.Item1 += " Chorrny";
            //Console.WriteLine($"Item 1 {t.Item1}\n" +
            //    $" --- \n" +
            //    $"Item 2 {t.Item2}\n"+
            //    $" --- \n" +
            //    $"Item 3 {t.Item3}\n"
            //    );
            var (name, age) = ("Alisa", 14);
            age = new Random().Next(0, 20);
            try
            {
                if (age >= 20)
                {
                    throw new Exception("More twenty...");
                }
                else
                    Console.WriteLine(age);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(age);
            }
            //Console.WriteLine(name);
            //Console.WriteLine(age);
        }
    }
}
