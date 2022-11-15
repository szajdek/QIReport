using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QIReport.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LowerLimit",
                table: "NominalDimensions");

            migrationBuilder.DropColumn(
                name: "UpperLimit",
                table: "NominalDimensions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "LowerLimit",
                table: "NominalDimensions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "UpperLimit",
                table: "NominalDimensions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
