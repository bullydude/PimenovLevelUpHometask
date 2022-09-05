using System.Reflection;

namespace Reflection
{
    internal class Examples
    {
        internal static void DealWithTypeInfo(Type type)
        {           
            Console.WriteLine(type.FullName); // System.String
            Console.WriteLine(type.Name); // String
            Console.WriteLine(type.IsValueType); // False

            var assembly = type.Assembly;
            Console.WriteLine(assembly.FullName); // System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e

            Console.WriteLine("\nFields:");
            var fields = type.GetFields();
            foreach (var field in fields)
            {
                Console.WriteLine($"\t{field.Name}");
            }

            Console.WriteLine("\nProperties:");
            var properties = type.GetProperties();
            foreach (var prop in properties)
            {
                Console.WriteLine($"\t{prop.Name}");
            }

            Console.WriteLine("\nMethods:");
            var methods = type.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine($"\t{method.Name}");
            }
        }

        internal static void DealWithInstance()
        {
            // Create instance via reflection - simplest way
            var weather = (Weather)Activator.CreateInstance(typeof(Weather))!;
            Console.WriteLine(weather.MakeForecast()); // Normal weather, 21C, wind 3 km/h

            // Get property info
            var weatherTypeProp = weather.GetType().GetProperty(nameof(Weather.WeatherType))!;

            // Get current property value
            var currentValue = weatherTypeProp.GetValue(weather);
            Console.WriteLine(currentValue); // Normal weather

            // Set property value
            weatherTypeProp.SetValue(weather, "Sunny");
            Console.WriteLine(weather.MakeForecast()); // Sunny, 21C, wind 3 km/h

            // Change the value of private field
            var privateField = weather.GetType().GetField(
                "_realWeather",
                BindingFlags.NonPublic | BindingFlags.Instance)!;

            Console.WriteLine(privateField.GetValue(weather));

            // Dirty hack! Don't repeat in your code! OOP, save our souls...
            privateField.SetValue(weather, "The weather in SPb is always beautiful!");

            Console.WriteLine(privateField.GetValue(weather));
        }

        class Weather
        {
            private string _realWeather = "I have no idea how to predict weather in SPb";
            
            public string? WeatherType { get; set; } = "Normal weather";

            public int DegreesC { get; set; } = 21;

            public int WindSpeed { get; set; } = 3;

            public string MakeForecast()
            {
                return $"{WeatherType}, {DegreesC}C, wind {WindSpeed} km/h";
            }
        }
    }
}
