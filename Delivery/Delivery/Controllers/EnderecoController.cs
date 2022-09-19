using Derivery.Domain.Entities;
using Derivery.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : Controller
    {
        private readonly IEnderecoService _service;

        public EnderecoController(IEnderecoService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("GetEndereco/{id:int}")]
        public async Task<ActionResult<Endereco>> GetEndereco(int id)
        {
            var result = await _service.getById(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddEndereco/")]
        public async Task<ActionResult<Endereco>> AddEndereco( [FromBody] Endereco endereco)
        {
            var result = await _service.Add(endereco);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdateEndereco/{id:int}")]
        public async Task<ActionResult<Endereco>> UpdateEndereco(int id, [FromBody] Endereco endereco)
        {
            var result = await _service.Update(id, endereco);
            return Ok(result);
        }

        [HttpDelete]
        [Route("DelEndereco/{id:int}")]
        public async Task<ActionResult<Endereco>> DelEndereco(int id)
        {
            await _service.Delete(id);
            return Ok();
        }
    }
}
