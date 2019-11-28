using System;

namespace Basic_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("John", "Doe", 20);

            Console.WriteLine(p1.age);
        }
    }
    class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
    }
}
