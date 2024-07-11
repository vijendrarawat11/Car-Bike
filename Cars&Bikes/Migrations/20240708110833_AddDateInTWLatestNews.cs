using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars_Bikes.Migrations
{
    /// <inheritdoc />
    public partial class AddDateInTWLatestNews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "TWLatestNews",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdditionalFeaturesOfVariant",
                table: "TWFeatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdjustableWindshield",
                table: "TWFeatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DistanceToEmptyIndicator",
                table: "TWFeatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "TWLatestNews");

            migrationBuilder.DropColumn(
                name: "AdditionalFeaturesOfVariant",
                table: "TWFeatures");

            migrationBuilder.DropColumn(
                name: "AdjustableWindshield",
                table: "TWFeatures");

            migrationBuilder.DropColumn(
                name: "DistanceToEmptyIndicator",
                table: "TWFeatures");
        }
    }
}
