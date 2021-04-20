using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqToObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinqDemo();
            List<Workers> workers = new List<Workers>()
            {
                new Workers(){Age = 25,Name = "Ivan",Department="Service",Salary = 1000},
                new Workers(){Age = 31,Name = "Anton",Department="Service",Salary = 1100},
                new Developer() {Age = 24,Name = "Vadim",Salary = 3000000,Languages = new List<string>{"C++",".NET","SQL"},Department = "IT" },
                new Developer() {Age = 34,Name = "Vladislav",Salary = 2100,Languages = new List<string>{"JAVA","Spring","SQL"},Department = "IT" },
                new Developer() {Name = "Andrii",Salary = 10000,Languages = new List<string>{"1C","1C Developer","Excel"},Department = "IT" },
                new DevOps(){Name = "Sergiy",Salary = 111,Technology = new List<string>{ "Bash","Docker","Python"},Department = "IT"  },
                new DevOps(){Name = "Foma",Salary = 1101,Technology = new List<string>{ "Java","Docker","PostgreSQL","Python"} ,Department = "IT"},
                new QA(){Name = "Tolik",Department = "IT",Salary = 12345,MethodTest = "Hand"},
                new Accounter(){Name = "Olga",Department = "IT",Salary = 12345678}
            };

            // 1
            var sort = (from e in workers
                        where e.Department == "Service" || e.Department == "IT"
                        orderby e.Age
                        select e);

            foreach (var item in sort)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine($"Average salary : {sort.Average(x => x.Salary)}");

            // 2 

            var devops = (from e in workers
                          where e.GetType().Name == "DevOps" 
                          && 
                          (e as DevOps).Technology.Contains("PostgreSQL")
                          select new
                          {
                              NameDevOps = e.Name,
                              TechDevOps = (e as DevOps).Technology,
                              SalaryDevOps = e.Salary
                          });
            Console.WriteLine("_____DEVOPS");
            foreach (var item in devops)
            {
                Console.WriteLine(item);
            }

            //3

            Console.WriteLine("____THIRDTASK");
            var name = (from e in workers
                        where e.Age < 30
                        orderby e.Name
                        select new { Age = e.Age, Name = e.Name});

            foreach (var item in name)
            {
                Console.WriteLine(item);
            }

            //4

            var group = from e in workers
                        group e by e.Age;
            foreach (var item in group)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Average(x => x.Salary));
                foreach (var l in item)
                {
                    Console.WriteLine(l);
                }
                
            }

            // 5
            Console.WriteLine("_________FIVE");
            var allworks = (from e in workers select e.Name).Distinct();
            Console.WriteLine($"{String.Join(",",allworks)}");

            // 6


            int[][] jugg = new int[2][]
            {
                new int[] {1,2,3,},
                new int[] {1,2,3,4,5,6,4,6,7,7}
            };

            var numb = (from e in jugg
                        from l in e
                        select l).Distinct();
            Console.WriteLine($"{String.Join(",",numb)}");               



            ////1 way
            //var allPeople = from e in workers
            //                orderby e.Salary descending
            //                select e;

            //// developer max salary

            //var maxDevSalary = (from e in workers
            //                    where e is Developer
            //                    select e).Max(x => x.Salary);

            //Console.WriteLine($"{maxDevSalary}");

            //var namesTypes = from e in workers // result = IEnumerable<string>
            //                 orderby e.GetType().Name
            //                 select $"{e.Name} {e.GetType().Name}";

            //Console.WriteLine("-------------Sorted");
            //foreach (var item in namesTypes)
            //{
            //    Console.WriteLine(item);
            //}

            //// anonymous type
            ////var car = new { Brand = "Audi",Power = 3.4,Year = 2020};
            ////Console.WriteLine(car);

            //// select form devops Name Salary and Count of StackTech
            //Console.WriteLine("_______________DEVOPS");
            //var devops = from e in workers
            //             where e is DevOps
            //             select new 
            //             {
            //                 NameDevOps = e.Name,
            //                 SalaryDevOps = e.Salary,
            //                 CountTechnology = (e as DevOps).Technology.Count() 
            //             };
            //foreach (var item in devops)
            //{
            //    Console.WriteLine($"Name devops {item.NameDevOps}\n" +
            //        $"Salary {item.SalaryDevOps}\n" +
            //        $"Count {item.CountTechnology}");
            //}

            //Console.WriteLine("\n----GROUP PEOPLE BY DEPARTMENT");
            //var resGroup = from e in workers orderby e.Department group e by e.Department;
            //foreach (var item in resGroup)
            //{
            //    Console.WriteLine($"---Department {item.Key}");
            //    foreach (var w in item)
            //    {
            //        Console.WriteLine($"{w}");
            //    }
            //}

            //var resultLang = (from e in workers
            //                 where e is Developer
            //                 from l in (e as Developer).Languages
            //                 select l).Distinct();
            //foreach (var item in resultLang)
            //{
            //    Console.WriteLine(item);
            //}
        }

        private static void LinqDemo()
        {
            // 1 way - query
            //var result = Array.FindAll(arr, x => x > 0);
            int[] arr = { 16, 6, 10, 11, 12, 13, 14, 77 };
            var negs = from e in arr
                       where e > 0 && e % 2 == 0
                       orderby e // сортування, по дефолту по зростанню // descending - до по спаданню
                       select e;
            foreach (var item in negs)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine($"MIN: {negs.Min()}");
            Console.WriteLine($"MAX: {negs.Max()}");

            // 2 way - extension methods
            string[] products = { "apple", "orange", "juice", "tomato", "strawberry" };
            var words = products.Where(p => p.ToLower().Contains('a')).OrderBy(p => p.Length); // search words with 'a'
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
