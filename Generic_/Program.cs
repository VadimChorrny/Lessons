using System;

namespace Generic_
{
    class Program
    {
        static void Main(string[] args)
        {
            Account<int> account = new Account<int>();
            Account<string> account1 = new Account<string>();
            //account.Id = 1234; // boxing
            //account1.Id = "1234567";

            //long id = account.Id; // unboxing
            //string id1 = account1.Id;
            //Console.WriteLine(account.Id.GetType());
            //Console.WriteLine(id1);

            Console.WriteLine(account);
        }
        class Account<T>
        {
            public T Id;
            public int Sum;
            public override string ToString()
            {
                return $"Type ID - {Id.GetType()}\nName - {Id.GetType().Name}";
            }
        }
        class ID { }
    }
}
