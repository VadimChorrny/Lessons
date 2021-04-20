using System;
using System.Collections.Generic;
using System.Text;

namespace Serealization_Tranning
{
    [Serializable]
    class Person
    {
        public string Name { get; set; }

        public uint Age { get; set; }

        //[NonSerialized]
        public uint ID;

        public Person(string name,uint age,uint id)
        {
            Name = name;
            Age = age;
            ID = id;
        }




    }
}
