using Microsoft.EntityFrameworkCore.Migrations;

namespace ClickExpress.Migrations
{
    public partial class AtualizandoPedidos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_ClienteId_usuario",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Prestadores_PrestadorId_usuario",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_ClienteId_usuario",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_PrestadorId_usuario",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "ClienteId_usuario",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "PrestadorId_usuario",
                table: "Pedidos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteId_usuario",
                table: "Pedidos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrestadorId_usuario",
                table: "Pedidos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ClienteId_usuario",
                table: "Pedidos",
                column: "ClienteId_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_PrestadorId_usuario",
                table: "Pedidos",
                column: "PrestadorId_usuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_ClienteId_usuario",
                table: "Pedidos",
                column: "ClienteId_usuario",
                principalTable: "Clientes",
                principalColumn: "Id_usuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Prestadores_PrestadorId_usuario",
                table: "Pedidos",
                column: "PrestadorId_usuario",
                principalTable: "Prestadores",
                principalColumn: "Id_usuario",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
