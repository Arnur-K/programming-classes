using System;

namespace Basic_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person
            {
                age = 20,
                firstName = " John",
                lastName = "Doe"
            };

            Console.WriteLine();
        }
    }
    class Person
    {
        public string firstName;
        public string lastName;
        public int age;
    }
}
