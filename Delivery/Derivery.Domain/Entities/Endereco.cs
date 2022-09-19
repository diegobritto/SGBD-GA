using System.ComponentModel.DataAnnotations;

namespace Derivery.Domain.Entities
{    
    public class Endereco
    {
        [Key]
        public int IdEndereco { get; set; }
        
        [Required]
        [MaxLength(8)]
        [MinLength(8)]
        public string Cep { get; set; }

        [Required]
        [MaxLength(150)]        
        public string Rua { get; set; }

        [Required]
        [MaxLength(150)]
        [MinLength(3)]
        public string Bairro { get; set; }

        [Required]
        [MaxLength(150)]
        [MinLength(3)]
        public string Cidade { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(2)]
        public string Pais { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(2)]
        public string Estado { get; set; }

        [Required]        
        public int Numero { get; set; }
        
        [MaxLength(250)]
        public string? Complemento { get; set; }
    }
}
