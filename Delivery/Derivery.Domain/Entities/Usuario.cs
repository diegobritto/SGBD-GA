
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Derivery.Domain.Entities
{
    public class Usuario
    {
        [Key()]
        public int IdUsuario { get; set; }
        [Required]
        public string Nome { get; set; }        
        public bool EhEstabelecimento { get; set; }
        [ForeignKey("Endereco")]
        public int IdEndereco { get; set; }
        [JsonIgnore]
        public Endereco Endereco { get; set; }
    }
}
