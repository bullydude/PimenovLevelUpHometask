using static System.Net.Mime.MediaTypeNames;

namespace Hometask_8_Observer_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumbersProcessor exampleNumbersProcessor = new NumbersProcessor();
            exampleNumbersProcessor.OnNumbersEntered += Method_summ;
            exampleNumbersProcessor.OnNumbersEntered += Method_reverse;

            Console.WriteLine($"Введите значения через пробел: ");
            string input = Console.ReadLine();
            int[] numbers = input
                            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            if (input != null)
            {
                Console.WriteLine($"введено значение: {input}");
                exampleNumbersProcessor.CallEvent(numbers);
            }
        }
        public static void Method_summ(int[] number_in)
        {
            int sum = number_in.Sum();
            Console.WriteLine(sum);
        }
        public static void Method_reverse(int[] array_in)
        {
            Array.Reverse(array_in);
            Console.WriteLine(string.Join(", ", array_in));
        }
    }
}