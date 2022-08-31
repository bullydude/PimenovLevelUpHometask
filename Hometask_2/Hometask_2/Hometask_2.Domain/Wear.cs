using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_2.Domain
{
    public sealed record Wear : StoreItem
    {
        public string Description { get; } = string.Empty;

        public WearSize Size { get; }

        public WearColor Color { get; }
    }
}
