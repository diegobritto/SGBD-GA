using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derivery.Domain.DTO
{
    public class PedidoDTO
    {
        public int IdPedido { get; set; }
        public double ValorTotal { get; set; }
        public char Status { get; set; }        
        public int IdFormaPagamento { get; set; }                
        public int IdEndereco { get; set; }                
        public int IdComprador { get; set; }
        public List<ProdutoPedidoDTO> Pedidos { get; set; }
    }
}
