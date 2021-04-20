using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqToObject
{
    class Workers
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; } = "Main";
        public int Age { get; set; } = 18;
        public override string ToString()
        {
            return $"{this.GetType().Name,-14}{Name,-10}{Department,-15}{Salary,-12}{Age,-12}";
        }

    }
    class Developer : Workers
    {
        public List<string> Languages { get; set; }
        public Developer() => Department = "IT";
        public override string ToString()
        {
            return $"{base.ToString()} Languages: {String.Join(",", Languages)}";
        }
    }
    class QA : Workers
    {
        public string MethodTest { get; set; }
        public QA() => Department = "IT";
        public override string ToString()
        {
            return $"{base.ToString()} Method Test: {MethodTest}";
        }

    }
    class DevOps : Workers
    {
        public List<string> Technology { get; set; }
        public DevOps() => Department = "IT";
        public override string ToString()
        {
            return $"{base.ToString()} Technology {String.Join(",",Technology)}";
        }
    }
    class Accounter : Workers
    {

        public Accounter() => Department = "Economics"; 

    }
    class Cleaner : Workers
    {
        public List<string> rooms { get; set; }
        Cleaner() => Department = "IT";
    }


}
