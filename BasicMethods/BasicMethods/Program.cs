using System;
using Math;

namespace BasicMethods
{
    class Program
    {
        static void Main(string[] args)
        {                                                   
            Console.WriteLine($"-5 {MathUtilities.isPrime(-5)}");
            Console.WriteLine($"0 {MathUtilities.isPrime(0)}");
            Console.WriteLine($"1 {MathUtilities.isPrime(1)}");
            Console.WriteLine($"2 {MathUtilities.isPrime(2)}");
            Console.WriteLine($"3 {MathUtilities.isPrime(3)}");
            Console.WriteLine($"4 {MathUtilities.isPrime(4)}");
            Console.WriteLine($"227 {MathUtilities.isPrime(227)}");
        }
    }
}
