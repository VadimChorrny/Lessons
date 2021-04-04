using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IDispose_Task
{
    class FileWorker : IDisposable
    {
    public enum Mode { Read = 1, Write,ReedWrite};
        bool isDispose = false;
        bool isOpen = false;
        FileStream fs = new FileStream("my.dat", FileMode.OpenOrCreate); // open stream
        public Mode mode;


        public FileWorker()
        {
            Console.WriteLine("FileWorker ctor worked!");
        }


        public void OnFileStream() => isOpen = true;
        public void CloseFileStream() => isOpen = false;

        public void SetOperation(Mode mode) => this.mode = mode;

        public void Write()
        {
            if ((int)mode == 1)
            {
                if (isOpen)
                    Console.WriteLine("We write data in file!");
                else
                    Console.WriteLine("FileStream closed!");
            }
            else
            {
                Console.WriteLine("This method only write or readwrite!");
            }
        }

        public void Read()
        {
            if ((int)mode == 2)
            {
                if (isOpen)
                    Console.WriteLine("We reed data in file!");
                else
                    Console.WriteLine("FileStream closed!");
            }
            else
            {
                Console.WriteLine("This method only reed with file!");
            }
        }

        public void ReadOrWrite()
        {
            if((int)mode == 3)
            {
                if(isOpen)
                {
                    Console.WriteLine($"Not found file, we write new file!");
                }
            }
            else
            {
                Console.WriteLine("error!");
            }
        }


        public virtual void Dispose(bool dispose)
        {
            if (!isDispose)
            {
                if (dispose)
                {
                    Console.WriteLine("we clear app!");
                }
                isDispose = true;
                GC.SuppressFinalize(this); // подавили виклик фіналізатора(бо вже звільнили ресурс - connect with db)

            }
        }
        public void Dispose()
        {
            isDispose = true;
            Console.WriteLine("Dispose has been used!");
        }



        ~FileWorker()
        {
            Console.WriteLine($"Finallizer worked!");
            Dispose();
        }
    }
}
