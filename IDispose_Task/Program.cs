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

            using (FileWorker fw = new FileWorker())
            {
                fw.OnFileStream();
                fw.SetOperation((FileWorker.Mode)2);
                fw.Read();
            }

            // 1 - Write

            // Dynamic Matrix


            byte[][] matrix = new byte[2][]
            {
                new byte[]{1,2,3,4,5},
                new byte[]{3,4,6,7,9 }
            };

            DynamicMatrix dm = new DynamicMatrix();
            string path = "matrix.dat";
            dm.WriteJugged(path, matrix);

            foreach (var item in matrix)
            {
                Console.WriteLine(" ");
                foreach (var item1 in item)
                    Console.WriteLine(item + " ");
                Console.WriteLine();
            }
        }

    }
}
