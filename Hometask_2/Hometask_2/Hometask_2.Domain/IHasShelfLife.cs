using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_2.Domain
{
    internal interface IHasShelfLife
    {
        public DateTime ExpirationDate { get; }

    }
}
