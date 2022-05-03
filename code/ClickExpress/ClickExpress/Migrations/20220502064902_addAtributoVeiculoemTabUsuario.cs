using Microsoft.EntityFrameworkCore.Migrations;

namespace ClickExpress.Migrations
{
    public partial class addAtributoVeiculoemTabUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Veiculo",
                table: "Prestadores");

            migrationBuilder.AddColumn<string>(
                name: "Veiculo",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Veiculo",
                table: "Usuarios");

            migrationBuilder.AddColumn<string>(
                name: "Veiculo",
                table: "Prestadores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
