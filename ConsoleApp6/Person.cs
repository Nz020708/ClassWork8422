using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public Person(string name,string surname,int age)
        {
            Name = name;
            SurName = surname;
            Age = age;
        }
        
    }
}
