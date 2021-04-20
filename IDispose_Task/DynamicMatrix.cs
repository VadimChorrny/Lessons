using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IDispose_Task
{
    class DynamicMatrix
    {
        public void WriteJugged(string path,byte[][] matrix)
        {
            using(FileStream fs = new FileStream(path,FileMode.OpenOrCreate))
            {
                foreach (var item in matrix)
                {
                    var row = BitConverter.GetBytes(item.Length);
                    fs.Write(row, 0, row.Length);
                    fs.Write(item, 0, item.Length);
                }
            }
        }
        
    }
}
