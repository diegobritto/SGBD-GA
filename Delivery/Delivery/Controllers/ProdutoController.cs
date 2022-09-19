using Derivery.Domain.DTO;
using Derivery.Domain.Entities;
using Derivery.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _service;

        public ProdutoController(IProdutoService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("GetProduto/{id:int}")]
        public async Task<ActionResult<Produto>> GetProduto(int id)
        {
            var result = await _service.getById(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddProduto/")]
        public async Task<ActionResult<Produto>> AddProduto( [FromBody] ProdutoDTO param)
        {
            Produto produto = new Produto
            {
                Descricao = param.Descricao,
                IdEstabelecimento = param.IdEstabelecimento,                
                Nome = param.Nome,
                Valor = param.Valor
            };
            var result = await _service.Add(produto);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdateProduto/{id:int}")]
        public async Task<ActionResult<Produto>> UpdateProduto(int id, [FromBody] ProdutoDTO param)
        {
            Produto produto = new Produto
            {
                Descricao = param.Descricao,
                IdEstabelecimento = param.IdEstabelecimento,
                IdProduto = param.IdProduto,
                Nome = param.Nome,
                Valor = param.Valor
            };
            var result = await _service.Update(id, produto);
            return Ok(result);
        }

        [HttpDelete]
        [Route("DelProduto/{id:int}")]
        public async Task<ActionResult<Produto>> DelProduto(int id)
        {
            await _service.Delete(id);
            return Ok();
        }
    }
}
