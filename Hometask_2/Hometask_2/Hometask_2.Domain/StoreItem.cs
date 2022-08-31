using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_2.Domain
{
    public abstract record StoreItem : IStoreItem
    {
        public Guid Id { get; }
        public ProductType ProductType { get; }
        public string Name { get; } = string.Empty;
        public decimal VendorPrice { get; }
        public decimal SellingPrice { get; }
    }
}
