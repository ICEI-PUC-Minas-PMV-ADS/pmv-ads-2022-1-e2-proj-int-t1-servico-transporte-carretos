using Microsoft.EntityFrameworkCore.Migrations;

namespace ClickExpress.Migrations
{
    public partial class AlterandoPedidosAdicionandoItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Estado_origem",
                table: "Pedidos",
                newName: "UF_origem");

            migrationBuilder.RenameColumn(
                name: "Estado_destino",
                table: "Pedidos",
                newName: "UF_destino");

            migrationBuilder.AddColumn<string>(
                name: "Cidade_destino",
                table: "Pedidos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cidade_origem",
                table: "Pedidos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Itens",
                columns: table => new
                {
                    Id_item = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PedidoId_contrato = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens", x => x.Id_item);
                    table.ForeignKey(
                        name: "FK_Itens_Pedidos_PedidoId_contrato",
                        column: x => x.PedidoId_contrato,
                        principalTable: "Pedidos",
                        principalColumn: "Id_contrato",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Itens_PedidoId_contrato",
                table: "Itens",
                column: "PedidoId_contrato");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Itens");

            migrationBuilder.DropColumn(
                name: "Cidade_destino",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Cidade_origem",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "UF_origem",
                table: "Pedidos",
                newName: "Estado_origem");

            migrationBuilder.RenameColumn(
                name: "UF_destino",
                table: "Pedidos",
                newName: "Estado_destino");
        }
    }
}
