using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_2.Domain
{
    internal interface IStoreItem
    {
        Guid Id { get; } 

        ProductType ProductType { get; }

        string Name { get; }

        decimal VendorPrice { get; }

        decimal SellingPrice { get; }

    }
}
