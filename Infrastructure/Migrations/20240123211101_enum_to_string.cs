using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class enum_to_string : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Meals");

            migrationBuilder.AddColumn<string>(
                name: "HealthRating",
                table: "Meals",
                type: "varchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Meals",
                type: "varchar(9)",
                maxLength: 9,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HealthRating",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Meals");

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Meals",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
