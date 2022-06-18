using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClickExpress.Migrations
{
    public partial class criandoTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id_usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Num_endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cpf_Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perfil = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id_usuario);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id_usuario = table.Column<int>(type: "int", nullable: false),
                    Id_cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
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
                name: "Pedidos",
                columns: table => new
                {
                    Id_contrato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dt_contrato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Cep_origem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logradouro_origem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complemento_origem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro_origem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade_origem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UF_origem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cep_destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logradouro_destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complemento_destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro_destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade_destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UF_destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dt_agendamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    Serv_descarrega = table.Column<bool>(type: "bit", nullable: false),
                    Serv_montagem = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Id_usuario = table.Column<int>(type: "int", nullable: false),
                    Id_cliente = table.Column<int>(type: "int", nullable: false),
                    Id_prestador = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id_contrato);
                    table.ForeignKey(
                        name: "FK_Pedidos_Usuarios_Id_usuario",
                        column: x => x.Id_usuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id_usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prestadores",
                columns: table => new
                {
                    Id_usuario = table.Column<int>(type: "int", nullable: false),
                    Id_prestador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Veiculo = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Orcamentos",
                columns: table => new
                {
                    Id_orcamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_contrato = table.Column<int>(type: "int", nullable: false),
                    Id_prestador = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    Status_orcamento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orcamentos", x => x.Id_orcamento);
                    table.ForeignKey(
                        name: "FK_Orcamentos_Pedidos_Id_contrato",
                        column: x => x.Id_contrato,
                        principalTable: "Pedidos",
                        principalColumn: "Id_contrato",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Itens_PedidoId_contrato",
                table: "Itens",
                column: "PedidoId_contrato");

            migrationBuilder.CreateIndex(
                name: "IX_Orcamentos_Id_contrato",
                table: "Orcamentos",
                column: "Id_contrato");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_Id_usuario",
                table: "Pedidos",
                column: "Id_usuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Itens");

            migrationBuilder.DropTable(
                name: "Orcamentos");

            migrationBuilder.DropTable(
                name: "Prestadores");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
