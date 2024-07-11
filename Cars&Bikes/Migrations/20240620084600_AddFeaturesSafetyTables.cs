using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars_Bikes.Migrations
{
    /// <inheritdoc />
    public partial class AddFeaturesSafetyTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Varients",
                table: "TWSpec",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TWFeatures",
                columns: table => new
                {
                    TWFeaturesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TWName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Varients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ABS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Speedometer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tripmeter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tachometer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LEDTailLight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Odometer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuelGauge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstrumentConsole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BodyGraphics = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clock = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassengerFootrest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoWheelerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TWFeatures", x => x.TWFeaturesId);
                    table.ForeignKey(
                        name: "FK_TWFeatures_Twowheelers_TwoWheelerId",
                        column: x => x.TwoWheelerId,
                        principalTable: "Twowheelers",
                        principalColumn: "TwoWheelerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TWSafety",
                columns: table => new
                {
                    TWSafetyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TWName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Varients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassSwitch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngineKillSwitch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Display = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoWheelerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TWSafety", x => x.TWSafetyId);
                    table.ForeignKey(
                        name: "FK_TWSafety_Twowheelers_TwoWheelerId",
                        column: x => x.TwoWheelerId,
                        principalTable: "Twowheelers",
                        principalColumn: "TwoWheelerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TWFeatures_TwoWheelerId",
                table: "TWFeatures",
                column: "TwoWheelerId");

            migrationBuilder.CreateIndex(
                name: "IX_TWSafety_TwoWheelerId",
                table: "TWSafety",
                column: "TwoWheelerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TWFeatures");

            migrationBuilder.DropTable(
                name: "TWSafety");

            migrationBuilder.DropColumn(
                name: "Varients",
                table: "TWSpec");
        }
    }
}
