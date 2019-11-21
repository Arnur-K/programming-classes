using System;

namespace VariousExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //OutParameters();
            Console.WriteLine(AVG());
        }
        private static double AVG(params int[] array)
        {
            if (array.Length == 0) return 0;
            var sum = 0;
            foreach (var item in array)
                sum += item;
            return sum / array.Length;
        }
        private static void OutParameters()
        {
            int a = 5; int b = 9;
            Swap(ref a, ref b);
            Console.WriteLine($"a: {a} b: {b}");
            if (int.TryParse("ten", out int c))
                Console.WriteLine(c);
            else
                Console.WriteLine("dupa");
        }
        private static void MethodWithOut(out int a)
        {
            a = 10;
        }
        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}