using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerable_
{

    class Week : IEnumerable
    {
        public List<String> Days = new List<string>() { "Monday", "Thursday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        public IEnumerator GetEnumerator()
        {
            return Days.GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Week week = new Week();
            week.Days.GetEnumerator();
        }
    }
}
