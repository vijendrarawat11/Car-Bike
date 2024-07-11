using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars_Bikes.Migrations
{
    /// <inheritdoc />
    public partial class VarientFKInSpec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Displacement",
                table: "TWSpec");

            migrationBuilder.AddColumn<int>(
                name: "TWVarientId",
                table: "TWSpec",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TWSpec_TWVarientId",
                table: "TWSpec",
                column: "TWVarientId");

            migrationBuilder.AddForeignKey(
                name: "FK_TWSpec_TWVarients_TWVarientId",
                table: "TWSpec",
                column: "TWVarientId",
                principalTable: "TWVarients",
                principalColumn: "TWVarientId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TWSpec_TWVarients_TWVarientId",
                table: "TWSpec");

            migrationBuilder.DropIndex(
                name: "IX_TWSpec_TWVarientId",
                table: "TWSpec");

            migrationBuilder.DropColumn(
                name: "TWVarientId",
                table: "TWSpec");

            migrationBuilder.AddColumn<string>(
                name: "Displacement",
                table: "TWSpec",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
