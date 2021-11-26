using Microsoft.AspNetCore.Mvc;
using Models;
using Models.Querys;
using Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace WebApiUsuarioEndereco.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public void Post([FromBody] User user)
        {

        }

        [HttpPost]
        [Route("list")]
        public ActionResult<IEnumerable<User>> List([FromBody] UserQuery userQuery)
        {
            try
            {
                var list = _userRepository.List(new Dictionary<string, object>()
                {
                    {"@Nome", userQuery.Nome},
                    {"@Sexo", userQuery.Sexo},

                });
                return Ok(list);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<User>> Get(int id)
        {
            try
            {
                var user = _userRepository.Get(new Dictionary<string, object>()
                {
                    { "@Id", id }
                });
                return Ok(user);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
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

