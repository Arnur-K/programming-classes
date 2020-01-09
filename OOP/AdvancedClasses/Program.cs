using System;

namespace AdvancedClasses
{

    class Program
    {

        public abstract class Pet
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public virtual void MakeSound() { }
            public Pet(string name, int age) {
                Name = name;
                Age = age;
            }
        }

        public class Dog : Pet
        {
            public Dog(string name, int age) : base(name, age) { }
            public override void MakeSound()
            {
                Console.WriteLine("Bark");
            }
        }

        public class Cat : Pet
        {
            public Cat(string name, int age) : base(name, age) { }
            public override void MakeSound()
            {
                Console.WriteLine("Wws");
            }
        }

        static void Main(string[] args)
        {
            /*Shape[] ourShapes =
            {
                new Triangle(3,4,5),
                new Square(8),
                new Circle(10),
                new Circle(5)
            };


            foreach(var shape in ourShapes)
            {
                Console.WriteLine(shape);
            }*/

            Pet tom = new Cat("Tom", 50);
            tom.MakeSound();
            tom = new Dog("Kotopes", 60);
            tom.MakeSound();
        }
    }
}
