using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derivery.Domain.DTO
{
    public class UsuarioDTO
    {
        [Key()]
        public int IdUsuario { get; set; }
        [Required]
        public string Nome { get; set; }
        public bool EhEstabelecimento { get; set; }
        [ForeignKey("Endereco")]
        public int IdEndereco { get; set; }
        
    }
}
