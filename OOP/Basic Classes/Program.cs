using System;

namespace Basic_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("John", "Doe", 20);
            Person p2 = new Person("Ann", "Doe", 25);
            Console.WriteLine($"{p1.GetFirstName()} {p1.GetLastName()} {p1.GetAge()}");
            p2.SetLastName("Grey");
            Console.WriteLine($"{p2.GetFirstName()} {p2.GetLastName()} {p2.GetAge()}");
        }
    }
    class Person
    {
         string firstName;
         string lastName;
         int age;
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            if (age < 0)
                throw new ArgumentOutOfRangeException("Ur face slapped");
            this.age = age;
        }
        public string GetFirstName() => firstName;
        public string GetLastName() => lastName;
        public int GetAge() => age;

        public void SetLastName(string newLastName)
        {
            if (newLastName == null)
                throw new ArgumentException("Ur face slapped");
            lastName = newLastName;
        }
    }
}
