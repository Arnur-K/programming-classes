using System;

namespace ExtensionMethods
{

    public static class StringUtilities
    {
        public static bool IsLongerThanFive(this string input) => input.Length > 5;

        public static bool IsFemaleName(this string input) => input.ToLower().EndsWith("a") && input.ToLower() != "kuba";
    }

    public static class IntUtilities
    {
        public static bool IsEven(this int input) => input % 2 == 0;
    }



    class Program
    {

        static void Main(string[] args)
        {
            string name = "Arnur";
            Console.WriteLine(name.IsLongerThanFive());

            int n1 = 6;
            int n2 = 13;

            Console.WriteLine(n1.IsEven());
            Console.WriteLine(n2.IsEven());


        }
    }
}
