using System.Collections.Generic;

namespace Hometask_5_square_roots_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number: ");
            int FirstArg = int.Parse(Console.ReadLine());
            Console.Write("Please enter second number: ");
            int SecondArg = int.Parse(Console.ReadLine());
            var startNumber = Math.Min(FirstArg, SecondArg);
            var finishNumber = Math.Max(FirstArg, SecondArg);
            var count = finishNumber - startNumber + 1;
            var range = Enumerable.Range(startNumber, count);
            Parallel.ForEach(range, SquareRootsCalc);
            
        }

        public static void SquareRootsCalc(int a)
        {
            Console.WriteLine($"Square root for {a} is {Math.Sqrt(a)}.");
        }
    }
}