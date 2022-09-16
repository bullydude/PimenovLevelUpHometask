using CoffeeStore.DataAccess.Context;
using CoffeeStore.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeStore.DataAccess
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly CoffeeStoreContext _dbContext;

        public ProductsRepository(CoffeeStoreContext DbContext)
        {
            _dbContext = DbContext;
        }

        public IEnumerable<ProductModel> GetAllProducts()
        {
            var res = _dbContext.Products;

            return res.Select(ConvertToProductModel).ToList();
        }

        public ProductType GetFirstProductType()
        {
            var res = _dbContext.ProductTypes;

            return res.Select(ConvertToProductTypeModel).First();
        }

        public void PostProduct(ProductModel model)
        {
            _dbContext.Products.Add(ConvertToProduct(model));
            _dbContext.SaveChanges();
        }

        private Product ConvertToProduct(ProductModel model)
        {
            return new Product
            {
                NomenclatureNumber = model.NomenclatureNumber,
                Name = model.Name,
                ProductTypeId = model.ProductTypeId,
                Description = model.Description
            };
        }
        private ProductModel ConvertToProductModel(Product prod)
        {
            return new ProductModel
            {
                Id = prod.Id,
                NomenclatureNumber = prod.NomenclatureNumber,
                Name = prod.Name,
                ProductTypeId = prod.ProductTypeId,
                Description = prod.Description
            };
        }
        private ProductType ConvertToProductTypeModel(ProductType prodType)
        {
            return new ProductType
            {
                Id = prodType.Id,
                Name = prodType.Name
            };
        }
    }
}
