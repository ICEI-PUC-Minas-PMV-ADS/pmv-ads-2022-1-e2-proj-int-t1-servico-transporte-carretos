using Microsoft.EntityFrameworkCore.Migrations;

namespace ClickExpress.Migrations
{
    public partial class addAtributoBairroemUsuarioeAlterNomeCpf_Cnpj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cpf_cnpj",
                table: "Usuarios",
                newName: "Cpf_Cnpj");

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "Cpf_Cnpj",
                table: "Usuarios",
                newName: "cpf_cnpj");
        }
    }
}
