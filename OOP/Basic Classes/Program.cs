using System;

namespace Basic_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Person p1 = new Person("John", "Zip", 0);
            Person p2 = new Person("Ann", "Doe", 0);
            p1.LastName = "Doe";
            Console.WriteLine($"{p1.FirstName} {p1.LastName} {p1.Age}");
            p2.LastName = "Grey";
            Console.WriteLine($"{p2.FirstName} {p2.LastName} {p2.Age}");
            Console.WriteLine(p1.GetFullName);
            Console.WriteLine(p1.IsAdult);*/


            Car c1 = new Car("Waz", 100, 5);
            Console.WriteLine($"{c1.Brand}, {c1.TankCapacity}, {c1.Consumption}");
            c1.Tank(50);
            Console.WriteLine($"Fuel level is  {c1.CurrentFuelLevel}");

            c1.Tank(14);
            c1.Drive(20);

            Console.WriteLine($"Fuel level is {c1.CurrentFuelLevel} kms {c1.TotalKm}");
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

        public string GetFullName => $"{firstName } {lastName}";

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public int Age => age;

        public bool IsAdult => age >= 18;

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
