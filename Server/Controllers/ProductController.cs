using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazingShop.Server.Services.ProductService;
using BlazingShop.Shared;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazingShop.Server.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productSevice;

        public ProductController(IProductService productService)
        {
            _productSevice = productService;
        }

        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            return Ok(await _productSevice.GetAllProducts());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return Ok(await _productSevice.GetProduct(id));
        }

        [HttpGet("Category/{categoryUrl}")]
        public async Task<ActionResult<List<Product>>> GetProductByCategory(string categoryUrl)
        {
            return Ok(await _productSevice.GetProductsByCategory(categoryUrl));
        }

      
    }
}

