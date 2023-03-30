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
    public class ReviewController : ControllerBase
    {
        private readonly ReviewRepository reviewRepository;

        public ReviewController(ClothingContext context)
        {
            this.reviewRepository = new ReviewRepository(context);
        }
        // GET: api/<ReviewController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/<ReviewController>
        [HttpPost]
        public IActionResult Post([FromBody] Review review)
        {
            using(var scope = new TransactionScope())
            {
                reviewRepository.InsertObject(review);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { ID = review.Id }, review);
            }
        }

        // PUT api/<ReviewController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReviewController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet("{productId}")]
        //GET api/<ReviewController>/productId
        public async Task<ActionResult<IEnumerable<Review>>> GetReviewsForProduct(int productId)
        {
            var review = await reviewRepository.GetReviewsForProduct(productId);
            return Ok(review);
        }
    }
}
