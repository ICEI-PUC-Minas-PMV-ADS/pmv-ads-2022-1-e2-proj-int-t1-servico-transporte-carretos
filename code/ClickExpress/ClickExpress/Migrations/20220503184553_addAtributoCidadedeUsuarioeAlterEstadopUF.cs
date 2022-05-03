using Microsoft.EntityFrameworkCore.Migrations;

namespace ClickExpress.Migrations
{
    public partial class addAtributoCidadedeUsuarioeAlterEstadopUF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Usuarios",
                newName: "UF");

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "UF",
                table: "Usuarios",
                newName: "Estado");
        }
    }
}
