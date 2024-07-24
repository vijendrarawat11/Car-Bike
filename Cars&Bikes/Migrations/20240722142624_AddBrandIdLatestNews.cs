using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars_Bikes.Migrations
{
    /// <inheritdoc />
    public partial class AddBrandIdLatestNews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Petrol",
                table: "TWBrands",
                newName: "IsPetrol");

            migrationBuilder.RenameColumn(
                name: "EV",
                table: "TWBrands",
                newName: "IsEV");

            migrationBuilder.AlterColumn<string>(
                name: "LaunchDate",
                table: "TwoWheelers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "TwoWBrandId",
                table: "TWLatestNews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TWLatestNews_TwoWBrandId",
                table: "TWLatestNews",
                column: "TwoWBrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_TWLatestNews_TWBrands_TwoWBrandId",
                table: "TWLatestNews",
                column: "TwoWBrandId",
                principalTable: "TWBrands",
                principalColumn: "TWBrandId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TWLatestNews_TWBrands_TwoWBrandId",
                table: "TWLatestNews");

            migrationBuilder.DropIndex(
                name: "IX_TWLatestNews_TwoWBrandId",
                table: "TWLatestNews");

            migrationBuilder.DropColumn(
                name: "TwoWBrandId",
                table: "TWLatestNews");

            migrationBuilder.RenameColumn(
                name: "IsPetrol",
                table: "TWBrands",
                newName: "Petrol");

            migrationBuilder.RenameColumn(
                name: "IsEV",
                table: "TWBrands",
                newName: "EV");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LaunchDate",
                table: "TwoWheelers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
