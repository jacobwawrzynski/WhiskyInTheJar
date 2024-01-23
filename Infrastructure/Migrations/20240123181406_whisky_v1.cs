using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class whisky_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stars",
                table: "Whiskies");

            migrationBuilder.AddColumn<double>(
                name: "HighestPrice",
                table: "Whiskies",
                type: "decimal(10, 2)",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "LowestPrice",
                table: "Whiskies",
                type: "decimal(10, 2)",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Whiskies",
                type: "varchar(9)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FoodCategory = table.Column<int>(type: "varchar(20)", nullable: false),
                    HealthRating = table.Column<int>(type: "varchar(7)", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Ingredients = table.Column<string>(type: "TEXT", nullable: false),
                    Preparing = table.Column<string>(type: "TEXT", nullable: true),
                    Category = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NutritionFacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Kcal = table.Column<int>(type: "INTEGER", nullable: false),
                    Protein = table.Column<double>(type: "REAL", nullable: false),
                    Fat = table.Column<double>(type: "REAL", nullable: false),
                    SaturatedFat = table.Column<double>(type: "REAL", nullable: true),
                    PolyunsaturatedFats = table.Column<double>(type: "REAL", nullable: true),
                    MonounsaturatedFats = table.Column<double>(type: "REAL", nullable: true),
                    Carbohydrates = table.Column<double>(type: "REAL", nullable: false),
                    Sugars = table.Column<double>(type: "REAL", nullable: true),
                    Fiber = table.Column<double>(type: "REAL", nullable: true),
                    ProductId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionFacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NutritionFacts_Items_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NutritionFacts_ProductId",
                table: "NutritionFacts",
                column: "ProductId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "NutritionFacts");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropColumn(
                name: "HighestPrice",
                table: "Whiskies");

            migrationBuilder.DropColumn(
                name: "LowestPrice",
                table: "Whiskies");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Whiskies");

            migrationBuilder.AddColumn<int>(
                name: "Stars",
                table: "Whiskies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
