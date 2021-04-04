using System;

namespace Garbage_Collector
{
    class Demo
    {
        public static int LastId = 0;
        public readonly int ID = ++LastId;
        int[] arr;
        public static int DefaultSize = 1_000_000;

        public Demo()
        {
            arr = new int[DefaultSize];
            Console.WriteLine($"Was created block #{ID}");
        }

        ~Demo() // finalizer
        {
            Console.WriteLine($"~~~REMOVED BLOCK #{ID}~~~");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GC.GetTotalMemory(false)/Math.Pow(2,10));


            int times = 10;
            Demo demo = new Demo();
            for (int i = 0; i < times; i++)
            {
                demo = new Demo();
            }
            Demo b = new Demo();
            for (int i = 0; i < times; i++)
            {
                b = new Demo();
            }


            Console.WriteLine($"############____a generation {GC.GetGeneration(demo)}");
            Console.WriteLine($"############____b generation {GC.GetGeneration(b)}");
            GC.Collect(0);
            Console.WriteLine($"############____a generation {GC.GetGeneration(demo)}");
            Console.WriteLine($"############____b generation {GC.GetGeneration(b)}");


            Demo c = new Demo();
            for (int i = 0; i < times; i++)
            {
                c = new Demo();
            }
            
        }
    }
}


// GC - очищає незайняті обьєкти які не використовуються