using Microsoft.EntityFrameworkCore.Migrations;

namespace poiesis_api.Migrations
{
    public partial class changeUsuariosAttNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GeneroDeEscritura",
                table: "Usuarios",
                newName: "generoDeEscritura");

            migrationBuilder.RenameColumn(
                name: "FrecuenciaDeLectura",
                table: "Usuarios",
                newName: "frecuenciaDeLectura");

            migrationBuilder.RenameColumn(
                name: "EleccionDiaYHorario",
                table: "Usuarios",
                newName: "eleccionDiaYHorario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "generoDeEscritura",
                table: "Usuarios",
                newName: "GeneroDeEscritura");

            migrationBuilder.RenameColumn(
                name: "frecuenciaDeLectura",
                table: "Usuarios",
                newName: "FrecuenciaDeLectura");

            migrationBuilder.RenameColumn(
                name: "eleccionDiaYHorario",
                table: "Usuarios",
                newName: "EleccionDiaYHorario");
        }
    }
}
