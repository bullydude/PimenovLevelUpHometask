using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_2.Domain
{
    public sealed record Food : StoreItem, IHasShelfLife
    {
        public string Description { get; } = string.Empty;

        DateTime IHasShelfLife.ExpirationDate { get; }
    }
}
