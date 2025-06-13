using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CadastroFuncionariosApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedFuncionarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Cargo = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "Id", "Cargo", "Nome" },
                values: new object[,]
                {
                    { 1, "Analista", "Fernanda" },
                    { 2, "Desenvolvedor", "Alexandre" },
                    { 3, "Coordenador", "Tiago" },
                    { 4, "TI", "Marcelo" },
                    { 5, "RH", "Bernadete" },
                    { 6, "Financeiro", "Fabrício" },
                    { 7, "Suporte", "Diogo" },
                    { 8, "Comercial", "Jéssica" },
                    { 9, "Marketing", "Karoline" },
                    { 10, "Administrativo", "Jaqueline" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionarios");
        }
    }
}
