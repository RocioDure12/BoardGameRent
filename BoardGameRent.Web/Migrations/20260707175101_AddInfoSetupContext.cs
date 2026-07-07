using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BoardGameRent.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddInfoSetupContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Apellido", "Dni", "Email", "NombreCompleto", "Rol", "Telefono" },
                values: new object[,]
                {
                    { 2, "Dure", "43023456", "rooci_16@hotmail.com.ar", "Evelyn", 1, "4234568" },
                    { 3, "Evelyn", "43023456", "taskplannerapplication@gmail.com", "Rocio", 2, "4234569" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
