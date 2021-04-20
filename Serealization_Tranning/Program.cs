using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Serealization_Tranning
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Person person0 = new Person("Vladislav!",19,1003);
            Person person1 = new Person("Bodya!",15,1004);

            Person[] people = new Person[] { person0, person1 };

            // create object for  BinaryFormatter

            BinaryFormatter formatter = new BinaryFormatter();




            string path = @"people.dat";
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(fs, people);
                Console.WriteLine("Object is serializated!");
            }



            using(FileStream fs = new FileStream(path,FileMode.Open))
            {
                Person[] newPerson = (Person[])formatter.Deserialize(fs);
                Console.WriteLine("Object is deserializated!");
                foreach (var item in newPerson)
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.Age);
                    Console.WriteLine(item.ID);
                }
            }



        }
    }
}
