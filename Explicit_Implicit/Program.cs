using System;

namespace Explicit_Implicit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Counter counter = new Counter() { Seconds = 200};
            //uint x = counter; // Yavne
            //Console.WriteLine(x);
        }
    }
    public class CounterMinutes
    { 
        public int Minutes { get; set; }
        public CounterMinutes(int minutes)
        {
            this.Minutes = minutes;
        }

        public static implicit operator CounterSeconds(CounterMinutes minutes)
        {
            return new CounterSeconds(minutes.Minutes); // neyavne
        }
    }

    public class CounterSeconds
    {
        //public uint Seconds { get; set; }
        //public static implicit operator Counter(uint x)
        //{
        //    return new Counter { Seconds = x };
        //}
        //public static implicit operator uint(Counter counter) // for Neyavne
        //{
        //    return counter.Seconds;
        //}
        //public static explicit operator uint(Counter counter) // for Yavne
        //{
        //    return counter.Seconds;
        //}

        public int Seconds { get; }
        public CounterSeconds(int seconds)
        {
            this.Seconds = seconds;
        }
    }

}
