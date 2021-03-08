using System;

namespace Assistante
{
    class Quest
    {
        public String State { get; set; }
        public String Old { get; set; }
        public String Job { get; set; }
        public String Name { get; set; }
        public String Hobby { get; set; }
    }

    interface IAction
    {
        public void Say(String text);
        public void SignSogn(String text);
        public void DrinkBear(String company);
        public void TrashHuman(String name);
    }

    class Warlus : IAction
    {
        private Quest quest = new Quest();
        public void Say(String text) { Console.WriteLine($"Warlus say ... {text}"); }
        public void SignSogn(String text) { Console.WriteLine("Warlus a sign-song... {text}"); }
        public void DrinkBear(String company){ Console.WriteLine($"Warlus drink bear company {company}"); }
        public void TrashHuman(String name) { Console.WriteLine($"Warlus trash human {name}"); }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Warlus warlus = new Warlus();
            warlus.Say("Эй Вася.. а ну стапэ!");
            warlus.DrinkBear("Жигулёвское");
            warlus.TrashHuman("Ивана");
        }
    }
}
