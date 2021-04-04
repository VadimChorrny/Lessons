using System;

namespace IDispose_Task
{
    class Program
    {
        static void Main(string[] args)
        {


            // без using


            //FileWorker fw = new FileWorker();
            //fw.OnFileStream(); // open
            //fw.SetOperation((FileWorker.Mode)1);
            //fw.Write();
            //fw.Dispose();

            // з using

            using(FileWorker fw = new FileWorker())
            {
                fw.OnFileStream();
                fw.SetOperation((FileWorker.Mode)2);
                fw.Read();
            }
        }
    }
}
