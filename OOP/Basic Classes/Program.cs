using System;

namespace Basic_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("John", "Doe", 20);
            Person p2 = new Person("Ann", "Doe", 25);
            Console.WriteLine($"{p1.FirstName} {p1.LastName} {p1.Age}");
            p2.LastName = "Grey";
            Console.WriteLine($"{p2.FirstName} {p2.LastName} {p2.Age}");
        }
    }
    class Person
    {
         string firstName;
         string lastName;
         int age;

        public string FirstName
        {
            get => firstName;
            set
            {
                if (value == null)
                    throw new ArgumentException("Ur face slapped");
                firstName = value;
            }
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public int Age
        {
            get => age;
        }

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            if (age < 0)
                throw new ArgumentOutOfRangeException("Ur face slapped");
            this.age = age;
        }
    }
}
