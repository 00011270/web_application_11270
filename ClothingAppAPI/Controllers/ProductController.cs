using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClothingAppAPI.Repository;
using ClothingAppAPI.DAL;
using ClothingAppAPI.Models;
using System.Transactions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClothingAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository productRepository;

        public ProductController(ClothingContext clothingContext)
        {
            productRepository = new ProductRepository(clothingContext);
            //productRepository = ProductRepository.GetInstance(clothingContext);
        }
        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return new OkObjectResult(await productRepository.GetObjectList());
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}" ,Name ="GetProductById")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await productRepository.GetObjectById(id);


            return new OkObjectResult(product);
        }

        // POST api/<ProductController>/
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Product product)
        {
            using(var scope = new TransactionScope())
            {
                await productRepository.InsertObject(product);
                scope.Complete();
                scope.Dispose();
                return CreatedAtAction(nameof(Get), new { ID = product.Id }, product);
            }
        }

        // PUT api/<ProductController>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Product product)
        {
            if(product != null)
            {
                using (var scope = new TransactionScope())
                {
                    await productRepository.UpdateObject(product);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await productRepository.DeleteObject(id);
            return new OkResult();
        }

        [HttpGet("category/{categoryId}", Name = "GetProductByCategoryId")]
        public async Task<IActionResult> GetByCategoryId(int categoryId)
        {
            var product = await productRepository.GetProductByCategoryId(categoryId);


            return new OkObjectResult(product);
        }
    }
}
