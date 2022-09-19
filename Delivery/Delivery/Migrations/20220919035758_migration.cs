using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Delivery.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Usuarios_EstabelecimentoIdUsuario",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_EstabelecimentoIdUsuario",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "EstabelecimentoIdUsuario",
                table: "Produtos");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_IdEstabelecimento",
                table: "Produtos",
                column: "IdEstabelecimento");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Usuarios_IdEstabelecimento",
                table: "Produtos",
                column: "IdEstabelecimento",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Usuarios_IdEstabelecimento",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_IdEstabelecimento",
                table: "Produtos");

            migrationBuilder.AddColumn<int>(
                name: "EstabelecimentoIdUsuario",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_EstabelecimentoIdUsuario",
                table: "Produtos",
                column: "EstabelecimentoIdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Usuarios_EstabelecimentoIdUsuario",
                table: "Produtos",
                column: "EstabelecimentoIdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
