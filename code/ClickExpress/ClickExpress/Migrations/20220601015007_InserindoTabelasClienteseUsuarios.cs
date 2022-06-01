using Microsoft.EntityFrameworkCore.Migrations;

namespace ClickExpress.Migrations
{
    public partial class InserindoTabelasClienteseUsuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteId_usuario",
                table: "Pedidos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id_cliente",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_prestador",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrestadorId_usuario",
                table: "Pedidos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id_usuario = table.Column<int>(type: "int", nullable: false),
                    Id_cliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id_usuario);
                    table.ForeignKey(
                        name: "FK_Clientes_Usuarios_Id_usuario",
                        column: x => x.Id_usuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id_usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prestadores",
                columns: table => new
                {
                    Id_usuario = table.Column<int>(type: "int", nullable: false),
                    Id_prestador = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestadores", x => x.Id_usuario);
                    table.ForeignKey(
                        name: "FK_Prestadores_Usuarios_Id_usuario",
                        column: x => x.Id_usuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id_usuario",
                        onDelete: ReferentialAction.Restrict);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_ClienteId_usuario",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Prestadores_PrestadorId_usuario",
                table: "Pedidos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Prestadores");

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
                name: "Id_cliente",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Id_prestador",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "PrestadorId_usuario",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Pedidos");
        }
    }
}
