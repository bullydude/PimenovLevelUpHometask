using Microsoft.AspNetCore.Mvc;
using CoffeeStore.DataAccess;
using CoffeeStore.DataAccess.Models;

namespace CoffeeStore.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController :ControllerBase
    {
        private readonly IProductsRepository _productsRepository;
        public ProductsController(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        [HttpGet(Name = "GetProducts")]
        public ActionResult<IEnumerable<ProductModel>> GetAllProducts()
        {
            var result = _productsRepository.GetAllProducts();
            return new JsonResult(result);
        }

        [HttpPost(Name = "AddProduct")]
        public void AddProduct([FromBody] ProductModel model)
        {
            _productsRepository.PostProduct(model);
        }
    }
}
