using System;

namespace Generics
{
    class Program
    {
        public class Pair<T, S>
        {
            public T First { get; set; }
            public S Second { get; set; }

            public Pair(T first, S second)
            {
                Second = second;
                First = first;
            }
        }

        static void Main(string[] args)
        {
            var firstPair = new Pair<int, int>(1,2);

            var secondPair = new Pair<string, string>("1", "2");

            var thirdPair = new Pair<int, DateTime>(1, DateTime.Now);

            Console.WriteLine(firstPair);
            Console.WriteLine(secondPair);
            Console.WriteLine(thirdPair);
        }
    }
}
