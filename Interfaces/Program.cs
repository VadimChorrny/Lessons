using System;

namespace Interfaces
{
    class Program
    {
        class Persone : ICloneable
        {
            public String Name = "Stark";
            public object Clone()
            {
                return this.MemberwiseClone(); // new Persone();
            }
        }

        class Human : IComparable
        {
            public string Name { get; }
            public int Age { get; }

            public int CompareTo(object obj)
            {
                Human human = obj as Human;
                if(human != null)
                {
                    return this.Name.CompareTo(human.Name);
                }
                else
                {
                    throw new Exception("Error");
                }
            }
        }
        static void Main(string[] args)
        {
            Persone persone = new Persone();
            Persone p2 = (Persone)persone;
            Console.WriteLine(p2.Name);
        }
    }
}
