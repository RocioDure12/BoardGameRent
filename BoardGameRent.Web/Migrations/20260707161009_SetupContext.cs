using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BoardGameRent.Web.Migrations
{
    /// <inheritdoc />
    public partial class SetupContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Juegos",
                columns: new[] { "Id", "Activo", "Descripcion", "EstaDisponible", "ImageUrl", "Nombre", "PrecioPorDia" },
                values: new object[,]
                {
                    { 1, true, "enjoy your game", true, "https://devirinvestments.s3.eu-west-1.amazonaws.com/img/catalog/product/8436017220100-1200-face3d.jpg", "Catan", 3000m },
                    { 2, true, "enjoy your game", true, "https://acdn-us.mitiendanube.com/stores/001/750/716/products/dixit_01-755cf40946eda097de17097563234968-640-0.webp", "Dixit", 1000m },
                    { 3, true, "enjoy your game", true, "https://acdn-us.mitiendanube.com/stores/001/029/049/products/cajitas-elegidas-parte-7-63-716b6f763d3bdfd50017516475086918-640-0.webp", "Carcassonne", 1000m }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Apellido", "Dni", "Email", "NombreCompleto", "Rol", "Telefono" },
                values: new object[] { 1, "Cacas", "43023456", "rocioevelyndure@gmail.com", "Melody Luz", 0, "4234567" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
