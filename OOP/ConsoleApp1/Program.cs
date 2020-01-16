using System;

namespace ConsoleApp1
{
    class Program
    {

        public interface IDrawable
        {
            void Draw();
        }

        public class Vehicle : IDrawable
        {
            public void Draw()
            {
                Console.WriteLine("Vehicle");
            }
        }

        public class  Square : IDrawable
        {
            public void Draw()
            {
                Console.WriteLine("Square");
            }
        }

        static void Main(string[] args)
        {
            IDrawable[] thingsToDraw = {
                new Square(),
                new Vehicle()
            };

            foreach( var i in thingsToDraw) {
                i.Draw();
            }
        }
    }
}
