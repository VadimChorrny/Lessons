using System;

namespace Event_Tranning
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account() { Sum = 100 };
            account.Notify += Message;
            account.Add(1100);
        }
        private static void Message(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
        }
    }
}
