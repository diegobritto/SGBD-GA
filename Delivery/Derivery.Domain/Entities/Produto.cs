using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Derivery.Domain.Entities
{
    public class Produto
    {
        [Key()]
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor{ get; set; }
        [ForeignKey("Estabelecimento")]
        public int IdEstabelecimento { get; set; }
        [JsonIgnore]
        public Usuario Estabelecimento { get; set; }
        [JsonIgnore]
        public ICollection<ProdutoPedido> Pedidos { get; set; }
    }
}
