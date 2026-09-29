using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Appversion.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionAndUnitMeasure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Product",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UnitMeasure",
                table: "Product",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UnitMeasure",
                table: "Product");
        }
    }
}
