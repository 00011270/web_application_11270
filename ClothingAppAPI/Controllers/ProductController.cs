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
        public IActionResult Get()
        {
            return new OkObjectResult(productRepository.GetObjectList());
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}" ,Name ="GetProductById")]
        public IActionResult Get(int id)
        {
            return new OkObjectResult(productRepository.GetObjectById(id));
        }

        // POST api/<ProductController>/
        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            using(var scope = new TransactionScope())
            {
                productRepository.InsertObject(product);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { ID = product.Id }, product);
            }
        }

        // PUT api/<ProductController>/5
        [HttpPut]
        public IActionResult Put([FromBody] Product product)
        {
            if(product != null)
            {
                using (var scope = new TransactionScope())
                {
                    productRepository.UpdateObject(product);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            productRepository.DeleteObject(id);
            return new OkResult();
        }
    }
}
