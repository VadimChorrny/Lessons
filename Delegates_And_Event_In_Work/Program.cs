using System;

namespace Delegates_And_Event_In_Work
{
    class Program
    {
        delegate string MyDelegate(int paramA, string paramB);
        delegate string HelloDelegate(string text);
        delegate void MyEventHandler(object sender, EventArgs args);

        //static event EventHandler MyEvent
        //{
        //    add
        //    {
        //        // Логіка обєднання
        //    }
        //    remove
        //    {
        //        // Логіка видалення
        //    }
        ////}

        class Boozer
        {
            public int BoozeAmount { get; private set; }
            public event EventHandler OilEnded;
            public Boozer()
            {
                BoozeAmount = 100;
            }
            private void Worker()
            {
                for (int i = BoozeAmount; i >= 0; i--)
                {
                    if (BoozeAmount == 0)
                    {
                        if (OilEnded != null)
                        {
                            OilEnded(this, new EventArgs());
                        }
                    }


                    BoozeAmount--;
                }
            }
            public void LetsGoDrink()
            {
                Worker();
            }
        }
        class Gopnik
        {
            public int SemkiAmount { get; private set; }
            public event EventHandler OilEnded;
            public Gopnik()
            {
                SemkiAmount = 250;
            }
            private void Worker()
            {
                for (int i = SemkiAmount; i >= 0; i--)
                {
                    if (SemkiAmount == 0)
                    {
                        if (OilEnded != null)
                        {
                            OilEnded(this, new EventArgs());
                        }
                    }


                    SemkiAmount--;
                }
            }
            public void LetsGoShelkat()
            {
                Worker();
            }
            delegate int MyDeleg(int x, int y);

            class AccountEventArgs
            {
                public string Message { get; }
                public int Sum { get; }
                public AccountEventArgs(string mess, int sum)
                {
                    Message = mess;
                    Sum = sum;
                }
            }

            class Account
            {
                public delegate void AccountHandler(object sender, AccountEventArgs e);
                public event AccountHandler Notify;
                public Account(int sum)
                {
                    Sum = sum;
                }
                public int Sum { get; set; }
                public void Put(int sum)
                {
                    Sum += sum;
                    Notify?.Invoke(this, new AccountEventArgs($"На счет поступило {sum}", sum));
                }
                public void Take(int sum)
                {
                    if (Sum >= sum)
                    {
                        Sum -= sum;
                        Notify?.Invoke(this, new AccountEventArgs($"Сумма {sum} снята со счета", sum));
                    }
                    else
                    {
                        Notify?.Invoke(this, new AccountEventArgs("Недостаточно денег на счете", sum)); ;
                    }
                }
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
                //var method = new MyDelegate(Method); // 1 спосіб
                //MyDelegate method2 = Method; // 2 спосіб

                //method(10, "huev");

                //var method = new HelloDelegate(SayHello);
                //method("Hi,Pidor!");

                //var boozer = new Boozer();
                //boozer.OilEnded += OnOilEnded; ;

                //var gopnik = new Gopnik();
                //gopnik.OilEnded += OnOilEnded;

                //gopnik.LetsGoShelkat();
                //boozer.LetsGoDrink();

                //Account account = new Account(100);
                //account.RegisterHandler(new Account.AccountStateHandler(ShowMessage));
                //account.Withdraw(100);
                //account.Put(1000);

                // anonim methods


                //MyDeleg my = delegate (int x, int y) { return x + y; };
                //Console.WriteLine(my(6,3));

                // Lambda

                //MyDeleg my = (x, y) => x + y;
                //Console.WriteLine(my(1,8));

                // events

                //Account account = new Account(1000);
                //account.Notify += ShowMessage;
                //account.Put(999);

                // EventArgs

                Account acc = new Account(100);
                acc.Notify += ShowMessage;
                acc.Put(100);
                acc.Take(91);

            }
            private static void ShowMessage(object sender,AccountEventArgs e)
            {
                Console.WriteLine($"Summ transaction : {e.Sum}");
                Console.WriteLine(e.Message);
            }
            //private static void ShowMessage(string mess)
            //{
            //    Console.WriteLine(mess);
            //}
            private static void OnOilEnded(object sender, EventArgs args)
            {
                if (sender is Gopnik)
                {
                    Console.WriteLine("Are you have a semki?");
                }
                else
                {
                    Console.WriteLine("I go to shop po dobavku!");
                }
            }
            static string SayHello(string text)
            {
                return text;
            }
            static string Method(int paramA, string paramB)
            {
                throw new NotImplementedException();
            }
        }
    }
}