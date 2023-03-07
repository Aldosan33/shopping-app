using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using ShoppingApp.Api.Data;

namespace ShoppingApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductDataContext _productDataContext;

        public ProductsController(ProductDataContext productDataContext)
        {
            _productDataContext = productDataContext ?? throw new ArgumentNullException(nameof(productDataContext));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _productDataContext.Products.Find(p => true).ToListAsync());
        }
    }
}
