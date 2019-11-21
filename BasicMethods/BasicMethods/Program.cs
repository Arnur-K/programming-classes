using System;
using Maths;

namespace BasicMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(MathUtilities.AreCoprime(5, 6));
            //var solutions = MathUtilities.SolveQuadratic(1, 0, 1);
            //foreach(var s in solutions)
            //{
            //    Console.WriteLine(s);
            //}
            Console.WriteLine(MathUtilities.ConvertTemp(100, MathUtilities.tempConversion.FromCToF));
        }
    }
}