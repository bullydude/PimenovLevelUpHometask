namespace StaticClassesAndMethods
{
    internal class ClassWithStaticMembersExample
    {
        // Instance field that wouldn't be shared between instances
        private readonly string _someInstanceData = "Default Instance Data";

        // Static field that would be shared between different instances
        private static string StaticData = "Static Data";

        // Instance ctor
        public ClassWithStaticMembersExample(string data)
        {
            _someInstanceData = data;
        }

        public void UseInstance()
        {
            Console.WriteLine(_someInstanceData); // OK
            Console.WriteLine(StaticData); // OK, we can interact with static data from instance method
        }

        public static void UseStatic()
        {
            // Console.WriteLine(_someInstanceData); // It wouldn't work; here we can use only static members
            Console.WriteLine(StaticData); // OK
        }

        public void ChangeStaticData(string newData)
        {
            StaticData = newData; // OK, we can interact with static data from instance method
        }
    }
}
