﻿// <auto-generated />
using Delivery.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Delivery.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220919042505_migration1")]
    partial class migration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Derivery.Domain.Entities.Endereco", b =>
                {
                    b.Property<int>("IdEndereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEndereco"), 1L, 1);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Complemento")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("IdEndereco");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Derivery.Domain.Entities.Pagamento", b =>
                {
                    b.Property<int>("IdPagamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPagamento"), 1L, 1);

                    b.Property<string>("FormaPagamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("IdPagamento");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("Derivery.Domain.Entities.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPedido"), 1L, 1);

                    b.Property<int>("CompradorIdUsuario")
                        .HasColumnType("int");

                    b.Property<int>("IdComprador")
                        .HasColumnType("int");

                    b.Property<int>("IdEndereco")
                        .HasColumnType("int");

                    b.Property<int>("IdFormaPagamento")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<double>("ValorTotal")
                        .HasColumnType("float");

                    b.HasKey("IdPedido");

                    b.HasIndex("CompradorIdUsuario");

                    b.HasIndex("IdEndereco");

                    b.HasIndex("IdFormaPagamento");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Derivery.Domain.Entities.Produto", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProduto"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdEstabelecimento")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("IdProduto");

                    b.HasIndex("IdEstabelecimento");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Derivery.Domain.Entities.ProdutoPedido", b =>
                {
                    b.Property<int>("IdProduto")
                        .HasColumnType("int");

                    b.Property<int>("IdPedido")
                        .HasColumnType("int");

                    b.Property<int>("Usuario")
                        .HasColumnType("int");

                    b.HasKey("IdProduto", "IdPedido");

                    b.HasIndex("IdPedido");

                    b.ToTable("ProdutoPedido");
                });

            modelBuilder.Entity("Derivery.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"), 1L, 1);

                    b.Property<bool>("EhEstabelecimento")
                        .HasColumnType("bit");

                    b.Property<int>("IdEndereco")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("IdEndereco");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Derivery.Domain.Entities.Pedido", b =>
                {
                    b.HasOne("Derivery.Domain.Entities.Usuario", "Comprador")
                        .WithMany()
                        .HasForeignKey("CompradorIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Derivery.Domain.Entities.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("IdEndereco")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Derivery.Domain.Entities.Pagamento", "Pagamento")
                        .WithMany()
                        .HasForeignKey("IdFormaPagamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comprador");

                    b.Navigation("Endereco");

                    b.Navigation("Pagamento");
                });

            modelBuilder.Entity("Derivery.Domain.Entities.Produto", b =>
                {
                    b.HasOne("Derivery.Domain.Entities.Usuario", "Estabelecimento")
                        .WithMany()
                        .HasForeignKey("IdEstabelecimento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estabelecimento");
                });

            modelBuilder.Entity("Derivery.Domain.Entities.ProdutoPedido", b =>
                {
                    b.HasOne("Derivery.Domain.Entities.Pedido", "Pedido")
                        .WithMany("Produtos")
                        .HasForeignKey("IdPedido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Derivery.Domain.Entities.Produto", "Produto")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Derivery.Domain.Entities.Usuario", b =>
                {
                    b.HasOne("Derivery.Domain.Entities.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("IdEndereco")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("Derivery.Domain.Entities.Pedido", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("Derivery.Domain.Entities.Produto", b =>
                {
                    b.Navigation("Pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
