using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestiónGeneroPelicula.Migrations
{
    /// <inheritdoc />
    public partial class AgregarGenero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GeneroId",
                table: "Pelicula",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pelicula_GeneroId",
                table: "Pelicula",
                column: "GeneroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pelicula_Genero_GeneroId",
                table: "Pelicula",
                column: "GeneroId",
                principalTable: "Genero",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pelicula_Genero_GeneroId",
                table: "Pelicula");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropIndex(
                name: "IX_Pelicula_GeneroId",
                table: "Pelicula");

            migrationBuilder.DropColumn(
                name: "GeneroId",
                table: "Pelicula");
        }
    }
}
