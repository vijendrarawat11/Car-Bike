using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars_Bikes.Migrations.FourWheelerBrandDBMigrations
{
    /// <inheritdoc />
    public partial class addFWUpcomingAndLatestNews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FWLatestNews",
                columns: table => new
                {
                    FWLatestNewsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsHeading = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NewsSummary = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    NewsDetail = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FWLatestNews", x => x.FWLatestNewsId);
                });

            migrationBuilder.CreateTable(
                name: "UpcomingCars",
                columns: table => new
                {
                    UpcomingCarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UpcomingCarName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpcomingCarDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpectedLaunchDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpcomingCars", x => x.UpcomingCarId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FWLatestNews");

            migrationBuilder.DropTable(
                name: "UpcomingCars");
        }
    }
}
