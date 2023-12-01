using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cofee.data.Migrations
{
    /// <inheritdoc />
    public partial class seedproductdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Detail", "ImageUrl", "IsTrendingProduct", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "A coffee drink consisting of espresso with microfoam (steamed milk with fine, velvety bubbles).", "/images/cofeeimages/flat-white.jpg", true, "Flat White", 4.99m },
                    { 2, "Espresso mixed with hot chocolate and steamed milk, topped with whipped cream.", "/images/cofeeimages/mocha.jpg", false, "Mocha", 5.49m },
                    { 3, "A dessert coffee made by pouring a shot of hot espresso over a scoop of vanilla ice cream.", "/images/cofeeimages/affogato.jpg", true, "Affogato", 6.99m },
                    { 4, "A traditional method of preparing unfiltered coffee with finely ground coffee beans and spices.", "/images/cofeeimages/turkish-coffee.jpg", false, "Turkish Coffee", 7.99m },
                    { 5, "Chilled coffee served over ice, often sweetened and with the option of milk or cream.", "/images/cofeeimages/iced-coffee.jpg", true, "Iced Coffee", 3.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
