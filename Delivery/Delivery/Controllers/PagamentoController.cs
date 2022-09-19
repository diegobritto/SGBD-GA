using Derivery.Domain.Entities;
using Derivery.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : Controller
    {
        private readonly IPagamentoService _service;

        public PagamentoController(IPagamentoService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("GetPagamento/{id:int}")]
        public async Task<ActionResult<Pagamento>> GetPagamento(int id)
        {
            var result = await _service.getById(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddPagamento/")]
        public async Task<ActionResult<Pagamento>> AddPagamento([FromBody] Pagamento endereco)
        {
            var result = await _service.Add(endereco);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdatePagamento/{id:int}")]
        public async Task<ActionResult<Endereco>> UpdatePagamento(int id, [FromBody] Pagamento endereco)
        {
            var result = await _service.Update(id, endereco);
            return Ok(result);
        }

        [HttpDelete]
        [Route("DelPagamento/{id:int}")]
        public async Task<ActionResult<Endereco>> DelPagamento(int id)
        {
            await _service.Delete(id);
            return Ok();
        }
    }
}
