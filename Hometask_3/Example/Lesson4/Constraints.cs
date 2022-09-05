namespace Generics
{
    internal class Constraints
    {
        public class AGenericClass<T> where T : IComparable<T> { }

        public class UsingEnum<T> where T : System.Enum { }

        public class UsingDelegate<T> where T : System.Delegate { }

        public class Multicaster<T> where T : System.MulticastDelegate { }

        class MyClass<T, U>
            where T : class
            where U : struct
        { }

        public abstract class B
        {
            public void M<T>(T? item) where T : struct { }
            public abstract void M<T>(T? item);
        }

        public class D : B
        {
            // Without the "default" constraint, the compiler tries to override the first method in B
            public override void M<T>(T? item) where T : default { }
        }

        class NotNullContainer<T>
            where T : notnull
        {
        }

        class UnManagedWrapper<T>
            where T : unmanaged
        { }


    }
}
