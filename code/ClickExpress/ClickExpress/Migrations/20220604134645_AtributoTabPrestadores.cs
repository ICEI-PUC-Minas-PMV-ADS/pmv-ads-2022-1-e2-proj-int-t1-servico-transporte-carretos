using Microsoft.EntityFrameworkCore.Migrations;

namespace ClickExpress.Migrations
{
    public partial class AtributoTabPrestadores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id_prestador",
                table: "Prestadores",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_prestador",
                table: "Prestadores");
        }
    }
}
