using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hometask_3
{
    internal record CachedValue<T>
    {
        
        public T? Value { get; init; }

        public DateTime CreationTime { get; init; }

        public int Timeout { get; init; }
    }
}
