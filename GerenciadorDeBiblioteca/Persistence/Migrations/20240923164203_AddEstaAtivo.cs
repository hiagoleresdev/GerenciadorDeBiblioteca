using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorDeBiblioteca.Migrations
{
    /// <inheritdoc />
    public partial class AddEstaAtivo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EstaEmpretado",
                table: "Livros",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstaEmpretado",
                table: "Livros");
        }
    }
}
