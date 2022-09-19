using Derivery.Domain.DTO;
using Derivery.Domain.Entities;
using Derivery.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _service;

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("GetUsuario/{id:int}")]
        public async Task<ActionResult<UsuarioDTO>> GetUsuario(int id)
        {
            var result = await _service.getById(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddUsuario/")]
        public async Task<ActionResult<UsuarioDTO>> AddUsuario([FromBody] UsuarioDTO param)
        {
            Usuario usuario = new Usuario { 
                EhEstabelecimento = param.EhEstabelecimento,
                Nome = param.Nome,
                IdEndereco = param.IdEndereco
                
            };
            var result = await _service.Add(param);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdateUsuario/{id:int}")]
        public async Task<ActionResult<UsuarioDTO>> UpdateUsuario(int id, [FromBody] UsuarioDTO param)
        {
            var result = await _service.Update(id, param);
            return Ok(result);
        }

        [HttpDelete]
        [Route("DelUsuario/{id:int}")]
        public async Task<ActionResult<UsuarioDTO>> DelUsuario(int id)
        {
            await _service.Delete(id);
            return Ok();
        }
    }
}
