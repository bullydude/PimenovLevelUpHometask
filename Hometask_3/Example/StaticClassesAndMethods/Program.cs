using StaticClassesAndMethods;

while (true)
{
    StaticClassExample.DoSomething();
    var key = Console.ReadLine();
    if (key == "q")
    {
        break;
    }
}

var obj1 = new ClassWithStaticMembersExample("Instance 1");
var obj2 = new ClassWithStaticMembersExample("Instance 2");

obj1.UseInstance();
obj2.UseInstance();

ClassWithStaticMembersExample.UseStatic();

obj1.ChangeStaticData("New Static Data From Obj1");
ClassWithStaticMembersExample.UseStatic();

obj2.ChangeStaticData("New Static Data From Obj2");
ClassWithStaticMembersExample.UseStatic();

