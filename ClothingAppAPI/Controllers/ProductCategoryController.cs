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
            productCategoryRepository = ProductCategoryRepository.GetInstance(clothingContext);
        }

        // GET: api/<ProductCategoryController>
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(productCategoryRepository.GetObjectList());
        }

        // GET api/<ProductCategoryController>/5
        [HttpGet("{id}", Name ="GetProductCategoryById")]
        public IActionResult Get(int id)
        {
            return new OkObjectResult(productCategoryRepository.GetObjectById(id));
        }

        // POST api/<ProductCategoryController>
        [HttpPost]
        public IActionResult Post([FromBody] ProductCategory productCategory)
        {
            using(var scope = new TransactionScope())
            {
                productCategoryRepository.InsertObject(productCategory);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { ID = productCategory.Id }, productCategory);
            }
        }

        // PUT api/<ProductCategoryController>/5
        [HttpPut]
        public IActionResult Put([FromBody] ProductCategory productCat)
        {
            if(productCat != null)
            {
                using(var scope = new TransactionScope())
                {
                    productCategoryRepository.UpdateObject(productCat);
                    scope.Complete();
                    return new OkResult();
                }

            }
            return new NoContentResult();
        }

        // DELETE api/<ProductCategoryController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            productCategoryRepository.DeleteObject(id);
            return new OkResult();
        }
    }
}
