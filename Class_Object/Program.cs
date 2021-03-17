using System;

namespace Class_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { Name = "Vadim" };
            Person person1 = new Person { Name = "Vadim" };
            Console.WriteLine(person.GetHashCode());
            Console.WriteLine(person1.GetHashCode());
            Console.WriteLine(person.Equals(person1));
        }
        // for ToString()
        class Person
        {
            public String Name { get; set; }
            public override string ToString()
            {
                if (String.IsNullOrEmpty(Name))
                    return base.ToString();
                return Name;
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }
        }

    }


}
