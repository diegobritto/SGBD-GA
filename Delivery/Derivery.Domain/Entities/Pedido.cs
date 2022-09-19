using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Derivery.Domain.Entities
{
    public class Pedido
    {
        [Key()]
        public int IdPedido { get; set; }
        public double ValorTotal { get; set; }
        public char Status { get; set; }
        [ForeignKey("Pagamento")]
        public int IdFormaPagamento { get; set; }
        public Pagamento Pagamento { get; set; }
        [ForeignKey("Endereco")]
        public int IdEndereco { get; set; }
        public Endereco Endereco { get; set; }

        [ForeignKey("Usuario")]
        public int IdComprador { get; set; }
        [JsonIgnore]
        public Usuario Usuario { get; set; }
        

        public ICollection<ProdutoPedido> Produtos { get; set; }
    }
}
