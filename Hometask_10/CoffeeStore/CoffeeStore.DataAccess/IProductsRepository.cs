using CoffeeStore.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeStore.DataAccess
{
    public interface IProductsRepository
    {
        public IEnumerable<ProductModel> GetAllProducts();
        public void PostProduct(ProductModel model);
        public ProductType GetFirstProductType();
    }
}
