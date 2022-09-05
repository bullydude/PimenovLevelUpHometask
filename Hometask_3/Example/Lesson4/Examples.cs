#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.

using System.Collections;
using System.Text.Json;

namespace Generics
{
    internal static class Examples
    {
        internal static void DealWithNonGenericCollections()
        {
            // ArrayList is able to store objects of any types (mixed) 
            ArrayList list = new ArrayList();
            list.Add("I'm a string");
            list.Add(15);
            list.Add(DateTime.Now);

            // If we want to process list or array items as items of concrete type,
            // we should cast each item to the needed type
            ArrayList regions = new ArrayList();
            regions.Add("RU-MSK");
            regions.Add("RU-SPB");
            regions.Add("EU-BER");
            regions.Add("EU-ROM");

            foreach (string item in regions)
            {
                if (item.StartsWith("RU"))
                {
                    Console.WriteLine("Russian region - {0}", item);
                }
            }

            // This one wouldn't work - items of regions list have System.Object type
            // string[] array = regions.ToArray();

            // This one works fine
            Array array = regions.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                var item = array.GetValue(i); // object
                var region = (string)item; // string

                if (region.StartsWith("RU")) // StartsWith is a System.String method
                {
                    Console.WriteLine("Russian region - {0}", item);
                }
            }
        }

        internal static void DealWithGenericCollections()
        {
            // List<string> is able to serve ONLY strings
            var regions = new List<string>
            {
                "RU-MSK",
                "RU-SPB",
                "EU-BER",
                "EU-ROM"
            };

            var first = regions[0]; // We can use list items via index
            Console.WriteLine(first.GetType().Name); // System.String

            foreach (string item in regions)
            {                
                if (item.StartsWith("RU"))
                {
                    Console.WriteLine("Russian region - {0}", item);
                }
            }

            string[] array = regions.ToArray(); // OK
            object[] arrayTwo = regions.ToArray(); // OK
        }

        internal static void DealWithSerialization()
        {   
            // Anonymous type - object's instance with several properties
            var student = new
            {
                Name = "Alexander",
                Surname = "Ivanov",
                Cource = 1,
                Speciality = "Informatics",
                Faculty = "ETF",
                Group = "EP-103"
            };

            // Serializer hides <T> from signature, because it knows
            // which type it tries to serialize
            var json = JsonSerializer.Serialize(student);
            Console.WriteLine(json); // -> string

            // When deserializing, we should explicitly set the destination type
            // (with System.Text.Json.JsonSerializer)
            var deserializedStudent = JsonSerializer.Deserialize<Student>(json); // <- from string
            Console.WriteLine(deserializedStudent.Name); // Alexander
        }

        internal static void DealWithActionsAndFunctions()
        {
            // Action - receives the argument of 'string'
            var reverter = new Action<string>(
                (string arg) =>
                {
                    Console.WriteLine(new string(arg.Reverse().ToArray()));
                });

            reverter.Invoke("Dambldore is alive!");
            reverter("I hope...");

            // Function - receives the argument of 'int', returns the 'int' result
            var splitter = new Func<int, int>(
                (int input) =>
                {
                    return input / 2;
                });

            var resultOne = splitter.Invoke(14);
            var resultTwo = splitter(26);

            Console.WriteLine(resultOne); // 7
            Console.WriteLine(resultTwo); // 13
        }

        class Student
        {
            public string? Name { get; set; }

            public string? SurName { get; set; }

            public int Cource { get; set; }

            public string? Speciality { get; set; }

            public string? Faculty { get; set; }

            public string? Group { get; set; }
        }
    }
}
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning restore CS8602 // Dereference of a possibly null reference.
