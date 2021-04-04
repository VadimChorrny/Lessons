using System;

namespace Delegates
{
    delegate void Message(string message);
    delegate int Operation(int x, int y);
    class Program
    {
        static void Hello(string name)
        {
            Console.WriteLine($"Hello! {name}");
        }
        static void Bye()
        {
            Console.WriteLine($"Bye!");
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Minus(int x, int y)
        {
            return x - y;
        }
        static string Chao() => "Chao man!";
        static void Main(string[] args)
        {
            Message message = new Message(Hello);
            message.Invoke("Sub!");
            message.Invoke("Bye");

            //Operation operation = Add;
            //int res = operation(5,5);
            //Console.WriteLine(res);

            //operation = Minus;
            //int result = operation(res, 1);
            //Console.WriteLine(result);

            //int tmp = operation(5, 1); // need 
            //Console.WriteLine(tmp);
        }
    }

}
