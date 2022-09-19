using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Derivery.Domain.Entities
{
    public class ProdutoPedido
    {        
        [ForeignKey("Produto")]
        public int IdProduto{ get; set; }
        public Produto Produto { get; set; }
     
        [ForeignKey("Pedido")]
        public int IdPedido { get; set; }
        public Pedido Pedido { get; set; }        
    }
}
