using System;
using System.Linq;

namespace Array_Traning
{

    // Book
    //class Book
    //{
    //    public String Author { get; set; }
    //    String Cypher { get; set; }
    //    public String Name { get; set; }
    //    String CreateYear { get; set; }
    //    public Book(String author, String cypher, String name, String year)
    //    {
    //        this.Author = author;
    //        this.Cypher = cypher;
    //        this.Name = name;
    //        this.CreateYear = year;
    //    }
    //    public void print()
    //    {
    //        Console.WriteLine(Author);
    //        Console.WriteLine(Cypher);
    //        Console.WriteLine(Name);
    //        Console.WriteLine(CreateYear);
    //    }
    //}

    //class Library
    //{
    //    private Book[] book;
    //    public Library() { book = new Book[0]; } // start init
    //    public void AddBook(Book books)
    //    {
    //        if (book == null)
    //        {
    //            return;
    //        }
    //        Array.Resize(ref book, book.Length + 1);
    //        book[book.Length - 1] = books;
    //    }
    //    public void RemoveBook(Book books)
    //    {
    //        Array.Resize(ref book, book.Length - 1);
    //    }
    //    public void SortByAuthor()
    //    {
    //        Array.Sort(book, (e, e1) => String.Compare(e.Author, e1.Author));
    //    }
    //    public void SortByAuthorByName()
    //    {
    //        SortByAuthor();
    //        Array.Sort(book, (e, e1) => String.Compare(e.Name, e1.Name));
    //    }

    //    public void SearchName(String Name)
    //    {
    //        int show = Array.FindIndex(book, (e) => e.Name == Name);
    //        book[show].print();
    //    }
    //    public void SearchAuthor(String Author)
    //    {
    //        int show = Array.FindIndex(book, (e) => e.Author == Author);
    //        book[show].print();
    //    }
    //    public void Render()
    //    {
    //        foreach (Book item in book)
    //        {
    //            if (book.Length > 0)
    //            {
    //                item.print();
    //                Console.WriteLine("***************");
    //            }
    //        }
    //    }
    //}

    class Program
    {

        static void Foo(out int a)
        {
            a = -5;
        }

        static void Main()
        {

            //int a = 2;
            //Foo(out a);
            // Console.WriteLine(a);

            // чотне не чотне

            //int numb = Convert.ToInt32(Console.ReadLine());
            //if(numb % 2 == 0)
            //{
            // Console.WriteLine("Number is chotne...");
            //}
            // else
            // {
            // Console.WriteLine("False number...");
            // }

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

            //// output reverse array
            //for (int i = arr.Length; i >= 0; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            //Console.WriteLine("Test");
            //// 7
            //int[] arr = { 1, -2, -3, 4, 5, -6, 1 - 1 };

            //int[] arr1 = Array.FindAll(arr, (e) => { return e < 0; });
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine($"Number : {arr1[i]}");
            //}
            //// analog method
            //int[] arr2 = Array.FindAll(arr, (e) => { return e >= 0; });
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.WriteLine($"Number pluser : {arr2[i]}");
            //}

            //// 10

            //int[] price = { 1, 2, 3, 4 };
            //String[] product = { "Ice", "Milk", "Water", "Cola" };
            //Array.Sort(price, product);

            //int[] arr = new int [10];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //arr[3] = 4;
            //arr[4] = 5;
            //arr[5] = 6;
            //arr[6] = 7;
            //arr[7] = 8;
            //arr[8] = 9;
            //arr[9] = 10;

            //Array.Resize(ref arr, arr.Length - 1);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            // Jugged Arrays

            //int[][] arr = new int[4][] // [4] - count arrays
            //{
            //    new int[4] {1,2,3,4},
            //    new [] {10,20,30},
            //    new [] {100,200,1000},
            //    new [] {1000,2000,3000}
            //};

            //Random random = new Random();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        arr[i][j] = random.Next(1000);
            //    }
            //}

            //// for output
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write($"{arr[i][j]}\n");
            //    }
            //}

            // ARRAY TEST
            //Array myArr = Array.CreateInstance(typeof(string), 5);
            //myArr.SetValue("Name", 0);
            //myArr.SetValue("Age", 1);
            //string s = (string)myArr.GetValue(1);
            //Console.WriteLine(s);

            int[] arr = { 1, 2, 3, 4, 3, 55, 23, 2, 5, 6, 2, 2 };
            var tmp = arr.Where(x => x % 2 == 0).Sum();
            Console.WriteLine(tmp);
        }

    }
}
