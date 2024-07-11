using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars_Bikes.Migrations
{
    /// <inheritdoc />
    public partial class addLaunchDateCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpectLaunchDate",
                table: "UpcomingBikes",
                newName: "ExpectedLaunchDate");

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "UpcomingBikes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsEV",
                table: "Twowheelers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LaunchDate",
                table: "Twowheelers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "UpcomingBikes");

            migrationBuilder.DropColumn(
                name: "IsEV",
                table: "Twowheelers");

            migrationBuilder.DropColumn(
                name: "LaunchDate",
                table: "Twowheelers");

            migrationBuilder.RenameColumn(
                name: "ExpectedLaunchDate",
                table: "UpcomingBikes",
                newName: "ExpectLaunchDate");
        }
    }
}
