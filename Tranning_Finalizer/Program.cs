using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tranning_Finalizer
{

    // Finalizer - призначений для видалення памяті з database,filestream etc..

    class DataBase
    {
        bool isDispose = false;
        bool isOpen = false;
        FileStream fs = new FileStream("my.dat", FileMode.OpenOrCreate); // open stream
        string nameDataBase = "noname";
        public DataBase()
        {
            Console.WriteLine("DataBase ctor worked!");
        }
        public void Open(string nameDB)
        {
            if(isOpen)
            {
                Console.WriteLine("DataBase opened! Need close!");
            }
            else
            {
                isOpen = true;
                Console.WriteLine("DataBase open!");
            }
        }
        public void Work()
        {
            if(isOpen)
            {
                Console.WriteLine("We add new file!");
            }
            else
            {
                Console.WriteLine("DataBase closed! Please open DB!");
            }
        }
        public void Dispose()
        {
            isDispose = true;
            Console.WriteLine($"Dispose has been used!");
        }
        public virtual void Dispose(bool disposing)
        {
            if(!isDispose)
            {
                if(disposing)
                {
                    Console.WriteLine("we clear app!");
                }
                isDispose = true;
                GC.SuppressFinalize(this); // подавили виклик фіналізатора(бо вже звільнили ресурс - connect with db)

            }
        }
        

        ~DataBase()
        {
            Console.WriteLine("Worked finalizer!");
            Dispose();
        }

    }

    

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
