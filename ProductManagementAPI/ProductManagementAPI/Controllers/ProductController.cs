using Microsoft.AspNetCore.Mvc;
using ProductManagementAPI.Data.Repositories;
using ProductManagementAPI.Model;
using System.Threading.Tasks;


namespace ProductManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            return Ok(await _productRepository.GetAllProducts());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductsDetails(int id)
        {
            return Ok(await _productRepository.GetProductsDetails(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody]Products products)
        {
            if (products == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var created = await _productRepository.InserProducts(products);

            return Created("created", created);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProducts([FromBody] Products products)
        {
            if (products == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _productRepository.UpdateProducts(products);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducts(int id)
        {
            
            await _productRepository.DeleteProducts(new Products { Id = id });

            return NoContent();
        }
    }
}
