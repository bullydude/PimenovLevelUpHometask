using System.Text.RegularExpressions;

namespace Hometask_1.DataRequest
{
    internal class Card
    {
        internal void DataRequest()
        {

            var DataPerson_str = string.Empty;
            var dataperson = new DataPerson();
            string[] _DataPerson = { dataperson.NAME,
                                     dataperson.SURNAME,
                                     dataperson.AGE,
                                     dataperson.HOBBY };

            for (int i = 0; i < _DataPerson.Length; i++)

            {
                while (true)
                {
                    Console.WriteLine($"\nEnter your {_DataPerson[i]}:");

                    DataPerson_str = Console.ReadLine() ?? string.Empty;

                    if (!CheckName(DataPerson_str, i))
                    {
                        Console.WriteLine("Incorrect value, please try again...");
                    }
                    else
                    {
                        _DataPerson[i] = DataPerson_str;
                        break;
                    };

                }

            }


            Console.WriteLine($"Name: {_DataPerson[0]} " +
                              $"Surname: {_DataPerson[1]} " +
                              $"Age: {_DataPerson[2]}  " +
                              $"Hobby: {_DataPerson[3]} ");
            Console.WriteLine(" ");

        }
        private static bool CheckName(string DataPerson_str, int i)
        {
            if (i < 2)
            {
                if (!Regex.IsMatch(DataPerson_str.Trim(), @"^[\p{L}\.\-]+$"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (i == 2)
                {
                    int age;
                    if (!int.TryParse(DataPerson_str, out age))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
               
            }

        }

    }

}


