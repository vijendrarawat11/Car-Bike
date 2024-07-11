using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars_Bikes.Migrations
{
    /// <inheritdoc />
    public partial class addTWVarient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TWVarients",
                columns: table => new
                {
                    TWVarientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Varients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TWName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoWheelerId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TWVarients", x => x.TWVarientId);
                    table.ForeignKey(
                        name: "FK_TWVarients_Twowheelers_TwoWheelerId",
                        column: x => x.TwoWheelerId,
                        principalTable: "Twowheelers",
                        principalColumn: "TwoWheelerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TWVarients_TwoWheelerId",
                table: "TWVarients",
                column: "TwoWheelerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TWVarients");
        }
    }
}
