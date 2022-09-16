using System.Text.RegularExpressions;

namespace Hometask_8_DeliveryAddressBuilder
{
    internal class DataCheck
    {
        public static string Check(string toCheck)
        {
            string toReturn;
            do
            {
                Console.Write($"Введите {toCheck}:");
            } while (!Regex.IsMatch(toReturn = Console.ReadLine(), @"^[a-zA-Zа-яА-ЯёЁ]+$"));
            return toReturn;
        }
        public static string CheckInt(string toCheck)
        {
            string toReturn;
            do
            {
                Console.Write($"Введите {toCheck}:");
            } while (!Regex.IsMatch(toReturn = Console.ReadLine(), @"^[0-9]+$"));
            return toReturn;
        }
    }
}
