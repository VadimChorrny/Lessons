using System;

namespace StringWS
{
    class Program
    {
        static void Main(string[] args)
        {
           // string text = @"Давно выяснено, что при оценке дизайна и композиции
           // читаемый текст мешает сосредоточиться. Lorem Ipsum используют потому,
           // что тот обеспечивает более или менее стандартное заполнение шаблона,
           // а также реальное распределение букв и пробелов в абзацах,
           // которое не получается при простой дубликации  Многие программы электронной вёрстки и редакторы HTML используют
           // Lorem Ipsum в качестве текста по умолчанию, так что поиск по ключевым словам ";
           // String[] words = text.Split(' ',5);
           // foreach (var item in words)
           // {
           //     Console.WriteLine(item);
           // }
           //string res =  String.Join(",", words,0,5);
           // Console.WriteLine($"{res}");
           // res = text.Replace("а",String.Empty);
           // Console.WriteLine($"{res}");
           // text.Substring(0, 20); // show vid 0 - 20 symbol
           // text.StartsWith("");
           // text.EndsWith("");
           // text.IndexOf('i');
            string texts = @"Lorem Ipsum is simply dummy text of the printing
            and typesetting industry. Lorem Ipsum has been the industry's standard dummy
            text ever since the 1500s, when an unknown printer took a galley of type and
            scrambled it to make a type specimen book. It has survived not only five cen
            turies, but also the leap into electronic typesetting, remaining essentially
            unchanged. It was popularised in the 1960s with the release of Letraset shee
            ts containing Lorem Ipsum passages, and more recently with desktop publishin
            g software like Aldus PageMaker including versions of Lorem Ipsum";
            String[] word = new String[] { texts};
            foreach (var item in word)
            {
                //Console.WriteLine(item);
            }

            String s = new String('V', 10);
            //Console.WriteLine(s); // VVVVVVVVVV

            // FOR CONCATINATION

            String name = "Vadim";
            String surname = "Chorrny";
            String con = String.Concat(name, surname," ! ");
            //Console.WriteLine(con);

            // FOR JOIN

            string[] arr = new string[] { name, surname };
            String pair = String.Join(" ", arr);
            //Console.WriteLine(pair);


            // FOR INDEXOF

            string s1 = "hello";
            int index = s1.IndexOf('l');
            //Console.WriteLine(index);

            // FOR TRIM

            string path = @"C:\SomeDir";
            path = path.Trim('r', 'i','C');
            //Console.WriteLine(path);

            // FOR SUBSTRING

            string hello = "Good day!";
            //hello = hello.Substring(5); // day!
            int count = hello.Length;
           // Console.WriteLine(count);
            hello = hello.Substring(0, hello.Length - 2); // index - 7
           // Console.WriteLine(hello);

            // FOR INSERT

            hello = hello.Insert(0, "Hello,");
            // Console.WriteLine(hello);


            // FOR REMOVE

            string texts1 = "Formula one";

            texts1 = texts1.Remove(0, 5);
            //Console.WriteLine(texts1);


            // FOR REPLACE

            String repl = "one two";
            repl = repl.Replace("one", "three"); // change one on three
            //Console.WriteLine(repl);

            // toLower toUpper

            String band = "SkriLLex";
            //band = band.ToLower(); // skrillex
            band = band.ToUpper(); // SKRILLEX
            Console.WriteLine(band);


        }
    }
}
