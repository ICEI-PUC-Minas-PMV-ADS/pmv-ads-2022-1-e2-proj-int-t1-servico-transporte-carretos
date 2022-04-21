using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClickExpress.Migrations
{
    public partial class RecriandoTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id_contrato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dt_contrato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    End_Destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    End_Partida = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Horario = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    Usuario_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id_contrato);
                    table.ForeignKey(
                        name: "FK_Pedidos_Usuarios_Usuario_Id",
                        column: x => x.Usuario_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Id_usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_Usuario_Id",
                table: "Pedidos",
                column: "Usuario_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pedidos");
        }
    }
}
