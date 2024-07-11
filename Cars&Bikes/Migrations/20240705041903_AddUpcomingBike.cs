using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars_Bikes.Migrations
{
    /// <inheritdoc />
    public partial class AddUpcomingBike : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UpcomingBikes",
                columns: table => new
                {
                    UpcomingBikeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UpcomingBikeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpcomingBikeDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpectLaunchDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpcomingBikes", x => x.UpcomingBikeId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UpcomingBikes");
        }
    }
}
