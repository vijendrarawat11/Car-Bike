using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars_Bikes.Migrations
{
    /// <inheritdoc />
    public partial class addcolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TwoWBrandId",
                table: "Twowheelers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Twowheelers_TwoWBrandId",
                table: "Twowheelers",
                column: "TwoWBrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Twowheelers_TwowheelerBrands_TwoWBrandId",
                table: "Twowheelers",
                column: "TwoWBrandId",
                principalTable: "TwowheelerBrands",
                principalColumn: "TWBrandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Twowheelers_TwowheelerBrands_TwoWBrandId",
                table: "Twowheelers");

            migrationBuilder.DropIndex(
                name: "IX_Twowheelers_TwoWBrandId",
                table: "Twowheelers");

            migrationBuilder.DropColumn(
                name: "TwoWBrandId",
                table: "Twowheelers");
        }
    }
}
