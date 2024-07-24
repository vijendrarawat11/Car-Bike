using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars_Bikes.Migrations
{
    /// <inheritdoc />
    public partial class addTWImageColorPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TWImageColorPrices",
                columns: table => new
                {
                    TWImageColorPriceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TWName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Varients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TwoWheelerId = table.Column<int>(type: "int", nullable: false),
                    TWVarientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TWImageColorPrices", x => x.TWImageColorPriceId);
                    table.ForeignKey(
                        name: "FK_TWImageColorPrices_TWVarients_TWVarientId",
                        column: x => x.TWVarientId,
                        principalTable: "TWVarients",
                        principalColumn: "TWVarientId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TWImageColorPrices_TwoWheelers_TwoWheelerId",
                        column: x => x.TwoWheelerId,
                        principalTable: "TwoWheelers",
                        principalColumn: "TwoWheelerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TWImageColorPrices_TwoWheelerId",
                table: "TWImageColorPrices",
                column: "TwoWheelerId");

            migrationBuilder.CreateIndex(
                name: "IX_TWImageColorPrices_TWVarientId",
                table: "TWImageColorPrices",
                column: "TWVarientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TWImageColorPrices");
        }
    }
}
