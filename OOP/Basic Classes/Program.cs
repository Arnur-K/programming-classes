using System;

namespace Basic_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.age = 20;
            Console.WriteLine(p1.age);
        }
    }
    class Person
    {
        public string firstName;
        public string lastName;
        public int age;
    }
}
