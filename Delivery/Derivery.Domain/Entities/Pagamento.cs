using System.ComponentModel.DataAnnotations;

namespace Derivery.Domain.Entities
{
    public class Pagamento
    {
        [Key()]
        public int IdPagamento { get; set; }
        public char Status { get; set; }
        public char FormaPagamento { get; set; }
    }
}
