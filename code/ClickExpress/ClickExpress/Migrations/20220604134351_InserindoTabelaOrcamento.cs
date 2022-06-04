using Microsoft.EntityFrameworkCore.Migrations;

namespace ClickExpress.Migrations
{
    public partial class InserindoTabelaOrcamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_prestador",
                table: "Prestadores");

            migrationBuilder.CreateTable(
                name: "Orcamentos",
                columns: table => new
                {
                    Id_orcamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_contrato = table.Column<int>(type: "int", nullable: false),
                    Id_prestador = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orcamentos", x => x.Id_orcamento);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orcamentos");

            migrationBuilder.AddColumn<int>(
                name: "Id_prestador",
                table: "Prestadores",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
