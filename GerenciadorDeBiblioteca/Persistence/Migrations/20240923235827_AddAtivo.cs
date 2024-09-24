using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorDeBiblioteca.Migrations
{
    /// <inheritdoc />
    public partial class AddAtivo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Emprestimo",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Emprestimo");
        }
    }
}
