using Microsoft.EntityFrameworkCore.Migrations;

namespace ClickExpress.Migrations
{
    public partial class ExcluindoClientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
