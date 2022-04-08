using System;
using System.Collections.Generic;
namespace ConsoleApp6
{
    class Program
    {

        static void Main(string[] args)
        {

            //Printfilegen<Pdf> a = new Printfilegen<Pdf>();
            //Excel excel = new Excel(5, 6);
            //Printfilegen<Excel>.Print(excel);
            Person p1 = new Person("Mark", "Dark", 34);
            Person p2 = new Person("A", "B", 23);
            Person p3 = new Person("C", "D", 25);
            Person p4 = new Person("E", "F", 21);
            Person p5 = new Person("Z", "K", 23);
            Person p6 = new Person("C", "M", 16);
            List<Person> a = new List<Person>();
            a.Add(p1);
            a.Add(p2);
            a.Add(p3);
            a.Add(p4);
            a.Add(p5);
            a.Add(p6);

            a.Sort((s1, s2) => s1.Age-s2.Age);
            foreach (var item in a)
            {
                Console.WriteLine(item.Name);
            }
            var x = a.FindLast(item => item.Age==23);
            Console.WriteLine(x.Name);
            var result = a.Exists(x => x.Name == "Mark");
            Console.WriteLine(result);

            //var x = a.Find(item => item.Age == 21);
            //var y = a.FindAll(item => item.Equals(21));

            //foreach (Person item in a)
            //{
            //    if (item.Age == 21)
            //    {
            //        y.Add(item);
            //    }
            //}

            //Console.WriteLine(x.Name);



        }

    }
}
