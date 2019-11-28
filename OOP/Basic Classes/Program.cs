using System;

namespace Basic_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("John", "Doe", 20);
            Console.WriteLine($"{p1.getAge()} {p1.getFirstName()} {p1.getLastName()}");
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
        public string getFirstName() => firstName;
        public string getLastName() => lastName;
        public int getAge() => age;
    }
}
