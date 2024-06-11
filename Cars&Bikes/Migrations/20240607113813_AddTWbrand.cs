using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars_Bikes.Migrations
{
    /// <inheritdoc />
    public partial class AddTWbrand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TwoWheelerBrandTWBrandId",
                table: "Twowheelers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Twowheelers_TwoWheelerBrandTWBrandId",
                table: "Twowheelers",
                column: "TwoWheelerBrandTWBrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Twowheelers_TwowheelerBrands_TwoWheelerBrandTWBrandId",
                table: "Twowheelers",
                column: "TwoWheelerBrandTWBrandId",
                principalTable: "TwowheelerBrands",
                principalColumn: "TWBrandId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Twowheelers_TwowheelerBrands_TwoWheelerBrandTWBrandId",
                table: "Twowheelers");

            migrationBuilder.DropIndex(
                name: "IX_Twowheelers_TwoWheelerBrandTWBrandId",
                table: "Twowheelers");

            migrationBuilder.DropColumn(
                name: "TwoWheelerBrandTWBrandId",
                table: "Twowheelers");
        }
    }
}
