using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqFeatures
{
    class Program
    {

        public class Vector
        {
            public double X { get; set; }
            public double Y { get; set; }

            public Vector() { }

            public Vector(int x, int y)
            {
                X = x;
                Y = y;
            }
            public override string ToString() => $"[{X}, {Y}]";
        }

        static void Main(string[] args)
        {
            //ArrayOfInts();
            //ListOfStrings();
            Vector v1 = new Vector(3, 4);
            Console.WriteLine(v1.ToString());
        }

        private static void ListOfStrings()
        {
            var names = new List<string>
            { "John", "Doe", "Petya", "Chy", "Ana", "Eve", "Alexa"};

            var sortByAlphabetically = names.OrderBy(x => x);

            var fromTheLongest = names.OrderBy(x => x.Length);

            var fromTheLongestToLowest = names.OrderByDescending(x => x.Length);

            var funnySort = names.OrderBy(x => x.Last());

            var groupedWithLength = names
                .GroupBy(x => x.Length)
                .OrderByDescending(x => x.Key);

            foreach (var i in groupedWithLength)
            {
                Console.WriteLine(i.Key);
                Console.WriteLine("-----------------");
                foreach (var j in i)
                {
                    Console.WriteLine(j);
                }
            }
        }

        private static void ArrayOfInts()
        {
            double[] grades = { 5, 4, 4, 2, 1, 3.5, 4.5, 2, 2 };
            var max = grades.Max();
            var min = grades.Min();
            var posGrades = grades.Where(x => x > 2);

            var goodGrades = grades.Where(x => x >= 3.5)
                .OrderBy(x => x);

            var score = grades
                .Where(x => x > 2)
                .Select(x => 3 * x + 10)
                .Sum();

            var fives = grades.Count(x => x == 5);

            var anyNegatives = grades.Any(x => x == 2);

            var allGradesAreWholeNumbers = grades.All(x => (int)x == x);

            var myFavGrades = grades.Skip(3).Take(2);

            var lestSideHasGreatAvg = grades.Take(grades.Length / 2).Average()
                > grades.Skip(grades.Length / 2).Average();
        }
    }
}
