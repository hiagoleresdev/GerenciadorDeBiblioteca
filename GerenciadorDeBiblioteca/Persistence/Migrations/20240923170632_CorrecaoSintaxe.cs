using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorDeBiblioteca.Migrations
{
    /// <inheritdoc />
    public partial class CorrecaoSintaxe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EstaEmpretado",
                table: "Livros",
                newName: "EstaEmprestado");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EstaEmprestado",
                table: "Livros",
                newName: "EstaEmpretado");
        }
    }
}
