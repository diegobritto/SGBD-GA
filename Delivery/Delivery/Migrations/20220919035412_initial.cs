using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Delivery.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoProduto_Pedidos_PedidosIdPedido",
                table: "PedidoProduto");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Endereco_IdEndereco",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Usuarios_EstabelecimentoIdUsuario",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Endereco_IdEndereco",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_EstabelecimentoIdUsuario",
                table: "Pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PedidoProduto",
                table: "PedidoProduto");

            migrationBuilder.DropIndex(
                name: "IX_PedidoProduto_ProdutosIdProduto",
                table: "PedidoProduto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "EstabelecimentoIdUsuario",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "IdEstabelecimento",
                table: "Pedidos");

            migrationBuilder.RenameTable(
                name: "Endereco",
                newName: "Enderecos");

            migrationBuilder.RenameColumn(
                name: "PedidosIdPedido",
                table: "PedidoProduto",
                newName: "Usuario");

            migrationBuilder.AddColumn<int>(
                name: "EstabelecimentoIdUsuario",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEstabelecimento",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PedidoProduto",
                table: "PedidoProduto",
                columns: new[] { "ProdutosIdProduto", "Usuario" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_EstabelecimentoIdUsuario",
                table: "Produtos",
                column: "EstabelecimentoIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoProduto_Usuario",
                table: "PedidoProduto",
                column: "Usuario");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoProduto_Pedidos_Usuario",
                table: "PedidoProduto",
                column: "Usuario",
                principalTable: "Pedidos",
                principalColumn: "IdPedido",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Enderecos_IdEndereco",
                table: "Pedidos",
                column: "IdEndereco",
                principalTable: "Enderecos",
                principalColumn: "IdEndereco",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Usuarios_EstabelecimentoIdUsuario",
                table: "Produtos",
                column: "EstabelecimentoIdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Enderecos_IdEndereco",
                table: "Usuarios",
                column: "IdEndereco",
                principalTable: "Enderecos",
                principalColumn: "IdEndereco",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoProduto_Pedidos_Usuario",
                table: "PedidoProduto");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Enderecos_IdEndereco",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Usuarios_EstabelecimentoIdUsuario",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Enderecos_IdEndereco",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_EstabelecimentoIdUsuario",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PedidoProduto",
                table: "PedidoProduto");

            migrationBuilder.DropIndex(
                name: "IX_PedidoProduto_Usuario",
                table: "PedidoProduto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "EstabelecimentoIdUsuario",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "IdEstabelecimento",
                table: "Produtos");

            migrationBuilder.RenameTable(
                name: "Enderecos",
                newName: "Endereco");

            migrationBuilder.RenameColumn(
                name: "Usuario",
                table: "PedidoProduto",
                newName: "PedidosIdPedido");

            migrationBuilder.AddColumn<int>(
                name: "EstabelecimentoIdUsuario",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEstabelecimento",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PedidoProduto",
                table: "PedidoProduto",
                columns: new[] { "PedidosIdPedido", "ProdutosIdProduto" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_EstabelecimentoIdUsuario",
                table: "Pedidos",
                column: "EstabelecimentoIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoProduto_ProdutosIdProduto",
                table: "PedidoProduto",
                column: "ProdutosIdProduto");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoProduto_Pedidos_PedidosIdPedido",
                table: "PedidoProduto",
                column: "PedidosIdPedido",
                principalTable: "Pedidos",
                principalColumn: "IdPedido",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Endereco_IdEndereco",
                table: "Pedidos",
                column: "IdEndereco",
                principalTable: "Endereco",
                principalColumn: "IdEndereco",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Usuarios_EstabelecimentoIdUsuario",
                table: "Pedidos",
                column: "EstabelecimentoIdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Endereco_IdEndereco",
                table: "Usuarios",
                column: "IdEndereco",
                principalTable: "Endereco",
                principalColumn: "IdEndereco",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
