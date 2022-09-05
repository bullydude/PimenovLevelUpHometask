using Generics;
using static Generics.Examples;

DealWithNonGenericCollections();
DealWithGenericCollections();
DealWithSerialization();
DealWithActionsAndFunctions();

var simpleCache = new SimpleCache();

// We store different types because of serialization
simpleCache.Store("1", "I'm a string");
simpleCache.Store("2", 42);
simpleCache.Store("3", DateTime.Now);

Console.WriteLine(simpleCache.Fetch<string>("1")); // OK, would be "I'm a string"
// Console.WriteLine(simpleCache.Fetch<string>("2")); // JsonException - should be int!
Console.WriteLine(simpleCache.Fetch<int>("2")); // OK, would be 42

var simpleStringCache = new SimpleGenericCache<string>();
simpleStringCache.Store("1", "I'm a string"); // OK
// simpleStringCache.Store("2", 42); // It wouldn't work, value should be string

Console.WriteLine(simpleStringCache.Fetch("1")); // OK, would be "I'm a string"

var simpleIntCache = new SimpleGenericCache<int>();
// simpleIntCache.Store("1", "I'm a string"); // It wouldn't work, value should be int
simpleIntCache.Store("2", 42); // OK

Console.WriteLine(simpleIntCache.Fetch("2")); // OK, would be 42