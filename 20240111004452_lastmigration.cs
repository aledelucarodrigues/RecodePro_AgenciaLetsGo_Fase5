using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LetsGo.Migrations
{
    /// <inheritdoc />
    public partial class lastmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "viagens",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "lets_genre", "lets_name", "lets_preco", "lets_url" },
                values: new object[] { "590", "Brasília", 159.99m, "https://agencialetsgo2.netlify.app/imagens/brasilia2.jpg" });

            migrationBuilder.UpdateData(
                table: "viagens",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "lets_genre", "lets_name", "lets_preco", "lets_url" },
                values: new object[] { "3.340", "São Paulo", 119.99m, "https://agencialetsgo2.netlify.app/imagens/saopaulo2.jpg" });

            migrationBuilder.UpdateData(
                table: "viagens",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "lets_genre", "lets_name", "lets_preco", "lets_url" },
                values: new object[] { "610", "Curitiba", 109.99m, "https://agencialetsgo2.netlify.app/imagens/Curitiba3.jpg" });

            migrationBuilder.UpdateData(
                table: "viagens",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "lets_genre", "lets_name", "lets_preco", "lets_url" },
                values: new object[] { "590", "Londrina", 99.99m, "https://agencialetsgo2.netlify.app/imagens/londrina2.jpg" });

            migrationBuilder.InsertData(
                table: "viagens",
                columns: new[] { "id", "lets_descricao", "lets_genre", "lets_name", "lets_preco", "lets_url" },
                values: new object[,]
                {
                    { 5, "", "188", "Manaus", 99.99m, "https://agencialetsgo2.netlify.app/imagens/manaus2.jpg" },
                    { 6, "", "3.430", "Rio de Janeiro", 109.99m, "https://agencialetsgo2.netlify.app/imagens/rio-de-janeiro2.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "viagens",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "viagens",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "viagens",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "lets_genre", "lets_name", "lets_preco", "lets_url" },
                values: new object[] { "RPG", "The Witcher 3", 59.99m, "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png" });

            migrationBuilder.UpdateData(
                table: "viagens",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "lets_genre", "lets_name", "lets_preco", "lets_url" },
                values: new object[] { "RPG", "The Witcher 2", 19.99m, "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png" });

            migrationBuilder.UpdateData(
                table: "viagens",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "lets_genre", "lets_name", "lets_preco", "lets_url" },
                values: new object[] { "RPG", "The Witcher", 9.99m, "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png" });

            migrationBuilder.UpdateData(
                table: "viagens",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "lets_genre", "lets_name", "lets_preco", "lets_url" },
                values: new object[] { "RPG", "Cyberpunk 2077", 59.99m, "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png" });
        }
    }
}
