using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars_Bikes.Migrations
{
    /// <inheritdoc />
    public partial class AddTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TWChargings",
                columns: table => new
                {
                    TWChargingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TWName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Varients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChargingAtHome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChargingAtChargingStation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoWheelerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TWChargings", x => x.TWChargingId);
                    table.ForeignKey(
                        name: "FK_TWChargings_Twowheelers_TwoWheelerId",
                        column: x => x.TwoWheelerId,
                        principalTable: "Twowheelers",
                        principalColumn: "TwoWheelerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TWChassisAndSuspensions",
                columns: table => new
                {
                    TWChassisAndSuspensionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TWName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Varients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BodyType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BodyGraphics = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoWheelerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TWChassisAndSuspensions", x => x.TWChassisAndSuspensionId);
                    table.ForeignKey(
                        name: "FK_TWChassisAndSuspensions_Twowheelers_TwoWheelerId",
                        column: x => x.TwoWheelerId,
                        principalTable: "Twowheelers",
                        principalColumn: "TwoWheelerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TWDimensionsAndCapacities",
                columns: table => new
                {
                    TWDimensionsAndCapacityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TWName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Varients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Width = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Length = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuelCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroundClearance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wheelbase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KerbWeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuelReserve = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaddleHeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoWheelerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TWDimensionsAndCapacities", x => x.TWDimensionsAndCapacityId);
                    table.ForeignKey(
                        name: "FK_TWDimensionsAndCapacities_Twowheelers_TwoWheelerId",
                        column: x => x.TwoWheelerId,
                        principalTable: "Twowheelers",
                        principalColumn: "TwoWheelerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TWElectricals",
                columns: table => new
                {
                    TWElectricalsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TWName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Varients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Headlight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TailLight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TurnSignalLamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LEDTailLights = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LowFuelIndicato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PilotLamps = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistanceToEmptyIndicator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DRLs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoWheelerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TWElectricals", x => x.TWElectricalsId);
                    table.ForeignKey(
                        name: "FK_TWElectricals_Twowheelers_TwoWheelerId",
                        column: x => x.TwoWheelerId,
                        principalTable: "Twowheelers",
                        principalColumn: "TwoWheelerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TWEngineAndTransmissions",
                columns: table => new
                {
                    TWEngineAndTransmissionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TWName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Varients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngineType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Displacement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxTorque = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumOfCylinders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoolingSystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValvePerCylinder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Starting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuelSupply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clutch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GearBox = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmissionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompressionRatio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ignition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoWheelerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TWEngineAndTransmissions", x => x.TWEngineAndTransmissionId);
                    table.ForeignKey(
                        name: "FK_TWEngineAndTransmissions_Twowheelers_TwoWheelerId",
                        column: x => x.TwoWheelerId,
                        principalTable: "Twowheelers",
                        principalColumn: "TwoWheelerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TWMileageAndPerformances",
                columns: table => new
                {
                    TWMileageAndPerformanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TWName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Varients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OverallMileage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityMileage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighwayMileage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoWheelerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TWMileageAndPerformances", x => x.TWMileageAndPerformanceId);
                    table.ForeignKey(
                        name: "FK_TWMileageAndPerformances_Twowheelers_TwoWheelerId",
                        column: x => x.TwoWheelerId,
                        principalTable: "Twowheelers",
                        principalColumn: "TwoWheelerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TWMotorAndBatteries",
                columns: table => new
                {
                    TWMotorAndBatteryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TWName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Varients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeakPower = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriveType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transmission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatteryCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoWheelerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TWMotorAndBatteries", x => x.TWMotorAndBatteryId);
                    table.ForeignKey(
                        name: "FK_TWMotorAndBatteries_Twowheelers_TwoWheelerId",
                        column: x => x.TwoWheelerId,
                        principalTable: "Twowheelers",
                        principalColumn: "TwoWheelerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TWTyresAndBrakes",
                columns: table => new
                {
                    TWTyresAndBrakesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TWName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Varients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontBrakeDiameter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RearBrakeDiameter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RadialTyre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontSuspension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RearSuspension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoWheelerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TWTyresAndBrakes", x => x.TWTyresAndBrakesId);
                    table.ForeignKey(
                        name: "FK_TWTyresAndBrakes_Twowheelers_TwoWheelerId",
                        column: x => x.TwoWheelerId,
                        principalTable: "Twowheelers",
                        principalColumn: "TwoWheelerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TWUnderpinnings",
                columns: table => new
                {
                    TWUnderpinningId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TWName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Varients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuspensionFront = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuspensionRear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrakesFront = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrakesRear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ABS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TyreSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WheelSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WheelType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TubelessTyre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoWheelerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TWUnderpinnings", x => x.TWUnderpinningId);
                    table.ForeignKey(
                        name: "FK_TWUnderpinnings_Twowheelers_TwoWheelerId",
                        column: x => x.TwoWheelerId,
                        principalTable: "Twowheelers",
                        principalColumn: "TwoWheelerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TWChargings_TwoWheelerId",
                table: "TWChargings",
                column: "TwoWheelerId");

            migrationBuilder.CreateIndex(
                name: "IX_TWChassisAndSuspensions_TwoWheelerId",
                table: "TWChassisAndSuspensions",
                column: "TwoWheelerId");

            migrationBuilder.CreateIndex(
                name: "IX_TWDimensionsAndCapacities_TwoWheelerId",
                table: "TWDimensionsAndCapacities",
                column: "TwoWheelerId");

            migrationBuilder.CreateIndex(
                name: "IX_TWElectricals_TwoWheelerId",
                table: "TWElectricals",
                column: "TwoWheelerId");

            migrationBuilder.CreateIndex(
                name: "IX_TWEngineAndTransmissions_TwoWheelerId",
                table: "TWEngineAndTransmissions",
                column: "TwoWheelerId");

            migrationBuilder.CreateIndex(
                name: "IX_TWMileageAndPerformances_TwoWheelerId",
                table: "TWMileageAndPerformances",
                column: "TwoWheelerId");

            migrationBuilder.CreateIndex(
                name: "IX_TWMotorAndBatteries_TwoWheelerId",
                table: "TWMotorAndBatteries",
                column: "TwoWheelerId");

            migrationBuilder.CreateIndex(
                name: "IX_TWTyresAndBrakes_TwoWheelerId",
                table: "TWTyresAndBrakes",
                column: "TwoWheelerId");

            migrationBuilder.CreateIndex(
                name: "IX_TWUnderpinnings_TwoWheelerId",
                table: "TWUnderpinnings",
                column: "TwoWheelerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TWChargings");

            migrationBuilder.DropTable(
                name: "TWChassisAndSuspensions");

            migrationBuilder.DropTable(
                name: "TWDimensionsAndCapacities");

            migrationBuilder.DropTable(
                name: "TWElectricals");

            migrationBuilder.DropTable(
                name: "TWEngineAndTransmissions");

            migrationBuilder.DropTable(
                name: "TWMileageAndPerformances");

            migrationBuilder.DropTable(
                name: "TWMotorAndBatteries");

            migrationBuilder.DropTable(
                name: "TWTyresAndBrakes");

            migrationBuilder.DropTable(
                name: "TWUnderpinnings");
        }
    }
}
