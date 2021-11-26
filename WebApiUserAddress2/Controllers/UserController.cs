using Microsoft.AspNetCore.Mvc;
using Dapper;
using Models;
using System.Collections.Generic;

namespace WebApiUsuarioEndereco.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpPost]
        public void Post([FromBody] User user)
        {

        }

        [HttpPost]
        [Route("list")]
        public IEnumerable<User> List()
        {
            return null;
        }

        [HttpGet("{id}")]
        public string GetById(int id)
        {
            return "value";
        }

        [HttpPut]
        public void Put()
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

