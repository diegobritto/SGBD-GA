using Derivery.Domain.DTO;
using Derivery.Domain.Entities;
using Derivery.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : Controller
    {
        private readonly IPedidoService _service;

        public PedidoController(IPedidoService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("GetPedido/{id:int}")]
        public async Task<ActionResult<Pedido>> GetPedido(int id)
        {
            var result = await _service.getById(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddPedido/")]
        public async Task<ActionResult<Pedido>> AddPedido([FromBody] PedidoDTO param)
        {
            List<ProdutoPedido> produtoPedidoList = new List<ProdutoPedido>();
            foreach (var item in param.Pedidos)
            {
                produtoPedidoList.Add(new ProdutoPedido { IdProduto = item.IdProduto });
            }
            Pedido pedido = new Pedido
            {
                IdComprador = param.IdComprador,
                IdEndereco = param.IdEndereco,
                IdFormaPagamento=param.IdFormaPagamento,
                Status = param.Status,
                ValorTotal = param.ValorTotal,
                Produtos = produtoPedidoList
            };
            var result = await _service.Add(pedido);

            return Ok(result);
        }

        [HttpPut]
        [Route("UpdatePedido/{id:int}")]
        public async Task<ActionResult<Endereco>> UpdatePedido(int id, [FromBody] PedidoDTO param)
        {
            List<ProdutoPedido> produtoPedidoList = new List<ProdutoPedido>();
            foreach (var item in param.Pedidos)
            {
                produtoPedidoList.Add(new ProdutoPedido { IdProduto = item.IdProduto });
            }
            Pedido pedido = new Pedido
            {
                IdPedido = id,
                IdComprador = param.IdComprador,
                IdEndereco = param.IdEndereco,
                IdFormaPagamento = param.IdFormaPagamento,
                Status = param.Status,
                ValorTotal = param.ValorTotal,
                Produtos = produtoPedidoList

            };
            var result = await _service.Update(id, pedido);
            return Ok(result);
        }

        [HttpDelete]
        [Route("DelPedido/{id:int}")]
        public async Task<ActionResult<Endereco>> DelPedido(int id)
        {
            await _service.Delete(id);
            return Ok();
        }
    }
}
