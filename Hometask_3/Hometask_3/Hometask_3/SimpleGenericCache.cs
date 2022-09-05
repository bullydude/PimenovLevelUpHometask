using Hometask_3;
using System.Collections.Generic;

namespace Hometask_3
{
    internal record SimpleGenericCache<T>
    {
        private readonly Dictionary<string, CachedValue<T?>> _cache = new();

        internal void Store(string key, T value, int timeout = 30)
        {
            var cashedValue = new CachedValue<T?> { Value = value, CreationTime = DateTime.Now, Timeout = timeout };
           _cache[key] = cashedValue;
        }

        internal CachedValue<T?> Fetch(string key)
        {
            
            if (_cache.TryGetValue(key, out var value))
            {
                if ((DateTime.Now - value.CreationTime).TotalSeconds <= value.Timeout )
                {
                    return value;
                }
                else
                {
                    _cache.Remove(key);
                    return default;
                }
                
            }

            return default;
        }
    }
}
