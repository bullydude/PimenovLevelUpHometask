using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeStore.DataAccess.Models
{
    public class ProductModel
    {
        public Guid Id { get; set; }
        public string NomenclatureNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
        public Guid ProductTypeId { get; set; }
        public string? Description { get; set; }
    }
}
