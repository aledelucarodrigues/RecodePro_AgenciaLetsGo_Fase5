using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LetsGo.Migrations
{
    /// <inheritdoc />
    public partial class secondmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "lets_descricao",
                table: "viagens",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "lets_url",
                table: "viagens",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "lets_descricao",
                table: "viagens");

            migrationBuilder.DropColumn(
                name: "lets_url",
                table: "viagens");
        }
    }
}
