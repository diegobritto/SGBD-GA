using Derivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ProdutoPedido>()
                .HasKey(ba => new { ba.IdProduto, ba.IdPedido });
            builder.Entity<ProdutoPedido>()
                .HasOne(ba => ba.Produto)
                .WithMany(ba => ba.Pedidos)
                .HasForeignKey(ba => ba.IdProduto);

            builder.Entity<ProdutoPedido>()
                .HasOne(ba => ba.Pedido)
                .WithMany(ba => ba.Produtos)
                .HasForeignKey(ba => ba.IdPedido);

        }      
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
