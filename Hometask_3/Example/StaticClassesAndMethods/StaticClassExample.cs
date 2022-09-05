namespace StaticClassesAndMethods
{
    internal static class StaticClassExample
    {
        static StaticClassExample()
        {
            Console.WriteLine("Called static ctor");
        }
        
        internal static void DoSomething()
        {
            Console.WriteLine("Do something outside");
            DoSomethingInside();
        }

        private static void DoSomethingInside()
        {
            Console.WriteLine("Do work");
        }
    }
}
