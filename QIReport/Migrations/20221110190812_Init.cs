using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QIReport.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PartTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdministrator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parts_PartTypes_PartTypeId",
                        column: x => x.PartTypeId,
                        principalTable: "PartTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InspectionReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BatchNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerialNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VisualInspectionStatus = table.Column<bool>(type: "bit", nullable: false),
                    InspectionStatus = table.Column<bool>(type: "bit", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AverageDimension = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DifferenceMaxMin = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectionReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InspectionReports_Parts_PartId",
                        column: x => x.PartId,
                        principalTable: "Parts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InspectionReports_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NominalDimensions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BalloonNo = table.Column<int>(type: "int", nullable: false),
                    NominalValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UpperDeviation = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LowerDeviation = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UpperLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LowerLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NominalDimensions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NominalDimensions_Parts_PartId",
                        column: x => x.PartId,
                        principalTable: "Parts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActualDimensions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActualValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Deviation = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsWithinTolerance = table.Column<bool>(type: "bit", nullable: false),
                    NominalDimensionId = table.Column<int>(type: "int", nullable: false),
                    InspectionReportId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActualDimensions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActualDimensions_InspectionReports_InspectionReportId",
                        column: x => x.InspectionReportId,
                        principalTable: "InspectionReports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActualDimensions_NominalDimensions_NominalDimensionId",
                        column: x => x.NominalDimensionId,
                        principalTable: "NominalDimensions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActualDimensions_InspectionReportId",
                table: "ActualDimensions",
                column: "InspectionReportId");

            migrationBuilder.CreateIndex(
                name: "IX_ActualDimensions_NominalDimensionId",
                table: "ActualDimensions",
                column: "NominalDimensionId");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionReports_PartId",
                table: "InspectionReports",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionReports_UserId",
                table: "InspectionReports",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_NominalDimensions_PartId",
                table: "NominalDimensions",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_Parts_PartTypeId",
                table: "Parts",
                column: "PartTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActualDimensions");

            migrationBuilder.DropTable(
                name: "InspectionReports");

            migrationBuilder.DropTable(
                name: "NominalDimensions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Parts");

            migrationBuilder.DropTable(
                name: "PartTypes");
        }
    }
}
