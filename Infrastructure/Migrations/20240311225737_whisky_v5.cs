using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class whisky_v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tags",
                table: "Whiskies",
                newName: "Type");

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Whiskies",
                type: "varchar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AddColumn<string>(
                name: "Aftertaste",
                table: "Whiskies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Aroma",
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
                name: "Aftertaste",
                table: "Whiskies");

            migrationBuilder.DropColumn(
                name: "Aroma",
                table: "Whiskies");

            migrationBuilder.DropColumn(
                name: "Taste",
                table: "Whiskies");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Whiskies",
                newName: "Tags");

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Whiskies",
                type: "varchar(9)",
                maxLength: 9,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar");
        }
    }
}
