using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Delivery.Migrations
{
    public partial class migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Usuarios_CompradorIdUsuario",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_CompradorIdUsuario",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "CompradorIdUsuario",
                table: "Pedidos");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_IdComprador",
                table: "Pedidos",
                column: "IdComprador");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Usuarios_IdComprador",
                table: "Pedidos",
                column: "IdComprador",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Usuarios_IdComprador",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_IdComprador",
                table: "Pedidos");

            migrationBuilder.AddColumn<int>(
                name: "CompradorIdUsuario",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_CompradorIdUsuario",
                table: "Pedidos",
                column: "CompradorIdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Usuarios_CompradorIdUsuario",
                table: "Pedidos",
                column: "CompradorIdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
