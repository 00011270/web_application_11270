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
    public class UserController : ControllerBase
    {
        private readonly UserRepository userRepo;

        public UserController(ClothingContext clothingContext)
        {
            userRepo = UserRepository.GetInstance(clothingContext);
        }

        // GET: api/<UserController>
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(userRepo.GetObjectList());
        }

        // GET api/<UserController>/5
        [HttpGet("{id}", Name ="GetUserById")]
        public IActionResult Get(int id)
        {
            return new OkObjectResult(userRepo.GetObjectById(id));
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            using (var scope = new TransactionScope())
            {
                userRepo.InsertObject(user);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { ID = user.Id }, user);
            }
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public IActionResult Put([FromBody] User user)
        {
            if (user != null)
            {
                using (var scope = new TransactionScope())
                {
                    userRepo.UpdateObject(user);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            userRepo.DeleteObject(id);
            return new OkResult();
        }
    }
}
