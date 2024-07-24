using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars_Bikes.Migrations
{
    /// <inheritdoc />
    public partial class addbrandidUpcoming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BrandName",
                table: "TWUpcomingBikes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TwoWBrandId",
                table: "TWUpcomingBikes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BrandName",
                table: "TWLatestNews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TWUpcomingBikes_TwoWBrandId",
                table: "TWUpcomingBikes",
                column: "TwoWBrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_TWUpcomingBikes_TWBrands_TwoWBrandId",
                table: "TWUpcomingBikes",
                column: "TwoWBrandId",
                principalTable: "TWBrands",
                principalColumn: "TWBrandId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TWUpcomingBikes_TWBrands_TwoWBrandId",
                table: "TWUpcomingBikes");

            migrationBuilder.DropIndex(
                name: "IX_TWUpcomingBikes_TwoWBrandId",
                table: "TWUpcomingBikes");

            migrationBuilder.DropColumn(
                name: "BrandName",
                table: "TWUpcomingBikes");

            migrationBuilder.DropColumn(
                name: "TwoWBrandId",
                table: "TWUpcomingBikes");

            migrationBuilder.DropColumn(
                name: "BrandName",
                table: "TWLatestNews");
        }
    }
}
