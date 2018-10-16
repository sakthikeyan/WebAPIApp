using ReactWebAPIApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ReactWebAPIApp.Controllers
{
    public class ProductsController : ApiController
    {
        ProductModel[] products = new ProductModel[]
                {
                new ProductModel { ProductId = 1, ProductName = "Tomato Soup", ProductCategory = "Groceries", ProductPrice = 1 ,ProductQuantity = 2},

                new ProductModel { ProductId = 2, ProductName = "Yo-yo",     ProductCategory = "Toys", ProductPrice = 3.75M ,ProductQuantity = 3},

                new ProductModel { ProductId = 3, ProductName = "Hammer",     ProductCategory = "Hardware", ProductPrice = 16.99M ,ProductQuantity = 4},

                new ProductModel { ProductId = 4, ProductName = "Sugar", ProductCategory = "Groceries", ProductPrice = 10 ,ProductQuantity = 5},

                new ProductModel { ProductId = 5, ProductName = "Chhota-Bheem", ProductCategory = "Toys", ProductPrice = 15 ,ProductQuantity = 6},

                new ProductModel { ProductId = 6, ProductName = "Printer", ProductCategory = "Hardware", ProductPrice = 120 ,ProductQuantity = 7}
                };


        // GET: api/Products  
        public List<ProductModel> Get()
        {
            return products.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult Get(int id)
        {
            var product = products.Where(x => x.ProductId == id).ToList();
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
