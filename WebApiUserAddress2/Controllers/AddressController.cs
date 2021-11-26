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
    public class AddressController : ControllerBase
    {
        private IAddressRepository _addressRepository;
        public AddressController( IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        [HttpPost]
        public void Post([FromBody] Address address)
        {

        }

        [HttpPost]
        [Route("list")]
        public ActionResult <IEnumerable<Address>> List([FromBody] AddressQuery addressQuery)
        {
            try
            {
                var list = _addressRepository.List(new Dictionary<string, object>()
                {
                    {"@Descricao", addressQuery.Descricao},
                    {"@Numero", addressQuery.Numero},
                    {"@Cep", addressQuery.Cep},

                }) ;
                    return Ok(list);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Address>> Get(int id)
        {
            try
            {
                var address = _addressRepository.Get(new Dictionary<string, object>()
                {
                    { "@Id", id }
                });
                return Ok(address);
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