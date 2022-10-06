using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ContosoCrafts.WebSite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
       public ProductsController(JsonFileProductService productService)
       {
            this.ProductService = productService;
       }


        public JsonFileProductService ProductService { get; }
    
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }

    }
}