using ClothingAppAPI.DAL;
using ClothingAppAPI.Models;
using ClothingAppAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClothingAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        private readonly ProductCategoryRepository productCategoryRepository;

        public ProductCategoryController(ClothingContext clothingContext)
        {
            productCategoryRepository =new ProductCategoryRepository(clothingContext);
        }

        // GET: api/<ProductCategoryController
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return new OkObjectResult(await productCategoryRepository.GetObjectList());
        }

        // GET api/<ProductCategoryController>/5
        [HttpGet("{id}", Name ="GetProductCategoryById")]
        public async Task<IActionResult> Get(int id)
        {
            return new OkObjectResult(await productCategoryRepository.GetObjectById(id));
        }

        // POST api/<ProductCategoryController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductCategory productCategory)
        {
            await productCategoryRepository.InsertObject(productCategory);
            return CreatedAtAction(nameof(Get), new { ID = productCategory.Id }, productCategory);
        }

        // PUT api/<ProductCategoryController>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] ProductCategory productCat)
        {
            if(productCat != null)
            {
                using(var scope = new TransactionScope())
                {
                    await productCategoryRepository.UpdateObject(productCat);
                    scope.Complete();
                    return new OkResult();
                }

            }
            return new NoContentResult();
        }

        // DELETE api/<ProductCategoryController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await productCategoryRepository.DeleteObject(id);
            return new OkResult();
        }
    }
}
