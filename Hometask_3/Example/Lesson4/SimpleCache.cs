using System.Text.Json;
namespace Generics
{
    internal class SimpleCache
    {
        private readonly Dictionary<string, string> _cache = new ();
        
        internal void Store<T>(string key, T value)
        {
            var serializedValue = JsonSerializer.Serialize(value);
            _cache[key] = serializedValue;
        }

        internal T? Fetch<T>(string key)
        {
            if (_cache.TryGetValue(key, out var value))
            {
                var deserializedValue = JsonSerializer.Deserialize<T>(value);
                return deserializedValue;
            }

            return default;
        }
    }
}
