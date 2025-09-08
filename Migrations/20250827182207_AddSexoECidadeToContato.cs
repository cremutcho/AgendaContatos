using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaContatos.Migrations
{
    /// <inheritdoc />
    public partial class AddSexoECidadeToContato : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Contatos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sexo",
                table: "Contatos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Contatos");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Contatos");
        }
    }
}
