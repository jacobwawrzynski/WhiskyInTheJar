using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class whisky_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AveragePrice",
                table: "Whiskies");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Whiskies",
                newName: "ImageUrl");

            migrationBuilder.AddColumn<int>(
                name: "AvgPriceUSD",
                table: "Whiskies",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Whiskies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Taste",
                table: "Whiskies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvgPriceUSD",
                table: "Whiskies");

            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Whiskies");

            migrationBuilder.DropColumn(
                name: "Taste",
                table: "Whiskies");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Whiskies",
                newName: "Image");

            migrationBuilder.AddColumn<double>(
                name: "AveragePrice",
                table: "Whiskies",
                type: "decimal(10, 2)",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
