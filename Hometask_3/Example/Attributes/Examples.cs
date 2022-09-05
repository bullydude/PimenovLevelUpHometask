using System.Reflection;

namespace Attributes
{
    internal class Examples
    {
        internal static void DealWithAttributesInfo()
        {
            var service = new SomeService();
            service.DoSomethingUseful();
            service.DoSomethingElse();
            service.DoSomethingAgain();

            var type = typeof(SomeService);
            var attributes = type.GetCustomAttributes(true);

            Console.WriteLine("SomeService attributes:");
            foreach (var item in attributes)
            {
                var attr = (Attribute)item;
                Console.WriteLine($"\tTypeId: {attr.TypeId}, IsDefaultAttribute: {attr.IsDefaultAttribute()}");
            }

            var method = type.GetMethod(nameof(SomeService.DoSomethingUseful))!;
            var methodAttributes = method.GetCustomAttributes(false);

            Console.WriteLine("SomeService.DoSomethingUseful attributes:");
            foreach (var item in methodAttributes)
            {
                var attr = (Attribute)item;
                Console.WriteLine($"\tTypeId: {attr.TypeId}, IsDefaultAttribute: {attr.IsDefaultAttribute()}");
            }

            var methodAttributesData = method.GetCustomAttributesData();
            foreach (var item in methodAttributesData)
            {
                var attr = (CustomAttributeData)item;
                Console.WriteLine($"\tType: {attr.AttributeType.FullName}");

                Console.WriteLine($"\tConstructor args:");
                foreach (var arg in attr.ConstructorArguments)
                {
                    Console.WriteLine($"\tType: {arg.ArgumentType}, Value: {arg.Value}");
                }
            }
        }
    }
}
