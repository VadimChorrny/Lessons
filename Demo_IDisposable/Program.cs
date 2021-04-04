using System;
using ST = System.Threading; // синонім назви простору
using static System.Console; // відкрили доступ до методів та вл-тей System.Console
using System.IO;

namespace Demo_IDisposable
{
    // керований ресурс - ним керує CLR
    // не керований ресурс(зєднання з БД, файлові дескриптори,зєднання по мережі,графічні ресурси)
    // - за звільнення CLR не відповідає
    // Класс, який оперує сирим не керованим ресурсом повинен реалізувати інтерфейс IDisposible
    class DBConnection : IDisposable
    {
        string nameDb;
        bool isOpen;
        bool isDispose = false;
        FileStream fs = new FileStream("my.dat", FileMode.OpenOrCreate);
        public DBConnection()
        {
            Console.WriteLine("DBConnection ctor");
        }
        public void Open(string nameDB)
        {
            if (isOpen)
            {
                Console.WriteLine($"DB {nameDB} was opened now!");
            }
            else
            {
                isOpen = true;
                this.nameDb = nameDB;
            }
        }
        public void Work()
        {
            Console.WriteLine("We got all records from table");
        }
        public void Dispose() // free
        {
            Dispose(true);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!isDispose)
            {

                if(disposing)
                {
                    Console.WriteLine("We are releasing managed resouse managed resurse");
                    fs.Dispose();
                }
                isOpen = false;
                Console.WriteLine($"Dispose done! Is opened {isOpen}");
                Console.WriteLine($"Dispose done! Is opened {isOpen}");
                isDispose = true;
                GC.SuppressFinalize(this); // подавили виклик фіналізатора(бо вже звільнили ресурс - connect with db)
            }
        }
        ~DBConnection()
        {
            Console.WriteLine("-----FINALIZER-----");
            Dispose(false);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            using (DBConnection db = new DBConnection())
            {
                db.Open("student.mdf");
                db.Work();
            }
        }
    }
}

// static - типу одна перемінна буде з одинаковими значеннями в різних обєктах
