using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars_Bikes.Migrations
{
    /// <inheritdoc />
    public partial class AddTWSpecTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TWSpec",
                columns: table => new
                {
                    TWSpecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TWName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Milage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontBrake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RearBrake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuelCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Displacement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoWheelerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TWSpec", x => x.TWSpecId);
                    table.ForeignKey(
                        name: "FK_TWSpec_Twowheelers_TwoWheelerId",
                        column: x => x.TwoWheelerId,
                        principalTable: "Twowheelers",
                        principalColumn: "TwoWheelerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TWSpec_TwoWheelerId",
                table: "TWSpec",
                column: "TwoWheelerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TWSpec");
        }
    }
}
