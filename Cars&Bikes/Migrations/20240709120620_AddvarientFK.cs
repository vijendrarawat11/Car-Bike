using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars_Bikes.Migrations
{
    /// <inheritdoc />
    public partial class AddvarientFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ABS",
                table: "TWUnderpinnings");

            migrationBuilder.AddColumn<int>(
                name: "TWVarientId",
                table: "TWUnderpinnings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TWVarientId",
                table: "TWTyresAndBrakes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BodyType",
                table: "TWSpec",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdditionalFeatures",
                table: "TWSafety",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RidingModes",
                table: "TWSafety",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TWVarientId",
                table: "TWSafety",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TractionControl",
                table: "TWSafety",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BrandLogoURL",
                table: "TwowheelerBrands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discription",
                table: "TwowheelerBrands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EV",
                table: "TwowheelerBrands",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Petrol",
                table: "TwowheelerBrands",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TWVarientId",
                table: "TWMotorAndBatteries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TWVarientId",
                table: "TWMileageAndPerformances",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TWVarientId",
                table: "TWFeatures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TWVarientId",
                table: "TWEngineAndTransmissions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TWVarientId",
                table: "TWElectricals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TWVarientId",
                table: "TWDimensionsAndCapacities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TWVarientId",
                table: "TWChassisAndSuspensions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TWVarientId",
                table: "TWChargings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TWUnderpinnings_TWVarientId",
                table: "TWUnderpinnings",
                column: "TWVarientId");

            migrationBuilder.CreateIndex(
                name: "IX_TWTyresAndBrakes_TWVarientId",
                table: "TWTyresAndBrakes",
                column: "TWVarientId");

            migrationBuilder.CreateIndex(
                name: "IX_TWSafety_TWVarientId",
                table: "TWSafety",
                column: "TWVarientId");

            migrationBuilder.CreateIndex(
                name: "IX_TWMotorAndBatteries_TWVarientId",
                table: "TWMotorAndBatteries",
                column: "TWVarientId");

            migrationBuilder.CreateIndex(
                name: "IX_TWMileageAndPerformances_TWVarientId",
                table: "TWMileageAndPerformances",
                column: "TWVarientId");

            migrationBuilder.CreateIndex(
                name: "IX_TWFeatures_TWVarientId",
                table: "TWFeatures",
                column: "TWVarientId");

            migrationBuilder.CreateIndex(
                name: "IX_TWEngineAndTransmissions_TWVarientId",
                table: "TWEngineAndTransmissions",
                column: "TWVarientId");

            migrationBuilder.CreateIndex(
                name: "IX_TWElectricals_TWVarientId",
                table: "TWElectricals",
                column: "TWVarientId");

            migrationBuilder.CreateIndex(
                name: "IX_TWDimensionsAndCapacities_TWVarientId",
                table: "TWDimensionsAndCapacities",
                column: "TWVarientId");

            migrationBuilder.CreateIndex(
                name: "IX_TWChassisAndSuspensions_TWVarientId",
                table: "TWChassisAndSuspensions",
                column: "TWVarientId");

            migrationBuilder.CreateIndex(
                name: "IX_TWChargings_TWVarientId",
                table: "TWChargings",
                column: "TWVarientId");

            migrationBuilder.AddForeignKey(
                name: "FK_TWChargings_TWVarients_TWVarientId",
                table: "TWChargings",
                column: "TWVarientId",
                principalTable: "TWVarients",
                principalColumn: "TWVarientId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TWChassisAndSuspensions_TWVarients_TWVarientId",
                table: "TWChassisAndSuspensions",
                column: "TWVarientId",
                principalTable: "TWVarients",
                principalColumn: "TWVarientId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TWDimensionsAndCapacities_TWVarients_TWVarientId",
                table: "TWDimensionsAndCapacities",
                column: "TWVarientId",
                principalTable: "TWVarients",
                principalColumn: "TWVarientId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TWElectricals_TWVarients_TWVarientId",
                table: "TWElectricals",
                column: "TWVarientId",
                principalTable: "TWVarients",
                principalColumn: "TWVarientId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TWEngineAndTransmissions_TWVarients_TWVarientId",
                table: "TWEngineAndTransmissions",
                column: "TWVarientId",
                principalTable: "TWVarients",
                principalColumn: "TWVarientId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TWFeatures_TWVarients_TWVarientId",
                table: "TWFeatures",
                column: "TWVarientId",
                principalTable: "TWVarients",
                principalColumn: "TWVarientId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TWMileageAndPerformances_TWVarients_TWVarientId",
                table: "TWMileageAndPerformances",
                column: "TWVarientId",
                principalTable: "TWVarients",
                principalColumn: "TWVarientId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TWMotorAndBatteries_TWVarients_TWVarientId",
                table: "TWMotorAndBatteries",
                column: "TWVarientId",
                principalTable: "TWVarients",
                principalColumn: "TWVarientId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TWSafety_TWVarients_TWVarientId",
                table: "TWSafety",
                column: "TWVarientId",
                principalTable: "TWVarients",
                principalColumn: "TWVarientId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TWTyresAndBrakes_TWVarients_TWVarientId",
                table: "TWTyresAndBrakes",
                column: "TWVarientId",
                principalTable: "TWVarients",
                principalColumn: "TWVarientId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TWUnderpinnings_TWVarients_TWVarientId",
                table: "TWUnderpinnings",
                column: "TWVarientId",
                principalTable: "TWVarients",
                principalColumn: "TWVarientId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TWChargings_TWVarients_TWVarientId",
                table: "TWChargings");

            migrationBuilder.DropForeignKey(
                name: "FK_TWChassisAndSuspensions_TWVarients_TWVarientId",
                table: "TWChassisAndSuspensions");

            migrationBuilder.DropForeignKey(
                name: "FK_TWDimensionsAndCapacities_TWVarients_TWVarientId",
                table: "TWDimensionsAndCapacities");

            migrationBuilder.DropForeignKey(
                name: "FK_TWElectricals_TWVarients_TWVarientId",
                table: "TWElectricals");

            migrationBuilder.DropForeignKey(
                name: "FK_TWEngineAndTransmissions_TWVarients_TWVarientId",
                table: "TWEngineAndTransmissions");

            migrationBuilder.DropForeignKey(
                name: "FK_TWFeatures_TWVarients_TWVarientId",
                table: "TWFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_TWMileageAndPerformances_TWVarients_TWVarientId",
                table: "TWMileageAndPerformances");

            migrationBuilder.DropForeignKey(
                name: "FK_TWMotorAndBatteries_TWVarients_TWVarientId",
                table: "TWMotorAndBatteries");

            migrationBuilder.DropForeignKey(
                name: "FK_TWSafety_TWVarients_TWVarientId",
                table: "TWSafety");

            migrationBuilder.DropForeignKey(
                name: "FK_TWTyresAndBrakes_TWVarients_TWVarientId",
                table: "TWTyresAndBrakes");

            migrationBuilder.DropForeignKey(
                name: "FK_TWUnderpinnings_TWVarients_TWVarientId",
                table: "TWUnderpinnings");

            migrationBuilder.DropIndex(
                name: "IX_TWUnderpinnings_TWVarientId",
                table: "TWUnderpinnings");

            migrationBuilder.DropIndex(
                name: "IX_TWTyresAndBrakes_TWVarientId",
                table: "TWTyresAndBrakes");

            migrationBuilder.DropIndex(
                name: "IX_TWSafety_TWVarientId",
                table: "TWSafety");

            migrationBuilder.DropIndex(
                name: "IX_TWMotorAndBatteries_TWVarientId",
                table: "TWMotorAndBatteries");

            migrationBuilder.DropIndex(
                name: "IX_TWMileageAndPerformances_TWVarientId",
                table: "TWMileageAndPerformances");

            migrationBuilder.DropIndex(
                name: "IX_TWFeatures_TWVarientId",
                table: "TWFeatures");

            migrationBuilder.DropIndex(
                name: "IX_TWEngineAndTransmissions_TWVarientId",
                table: "TWEngineAndTransmissions");

            migrationBuilder.DropIndex(
                name: "IX_TWElectricals_TWVarientId",
                table: "TWElectricals");

            migrationBuilder.DropIndex(
                name: "IX_TWDimensionsAndCapacities_TWVarientId",
                table: "TWDimensionsAndCapacities");

            migrationBuilder.DropIndex(
                name: "IX_TWChassisAndSuspensions_TWVarientId",
                table: "TWChassisAndSuspensions");

            migrationBuilder.DropIndex(
                name: "IX_TWChargings_TWVarientId",
                table: "TWChargings");

            migrationBuilder.DropColumn(
                name: "TWVarientId",
                table: "TWUnderpinnings");

            migrationBuilder.DropColumn(
                name: "TWVarientId",
                table: "TWTyresAndBrakes");

            migrationBuilder.DropColumn(
                name: "BodyType",
                table: "TWSpec");

            migrationBuilder.DropColumn(
                name: "AdditionalFeatures",
                table: "TWSafety");

            migrationBuilder.DropColumn(
                name: "RidingModes",
                table: "TWSafety");

            migrationBuilder.DropColumn(
                name: "TWVarientId",
                table: "TWSafety");

            migrationBuilder.DropColumn(
                name: "TractionControl",
                table: "TWSafety");

            migrationBuilder.DropColumn(
                name: "BrandLogoURL",
                table: "TwowheelerBrands");

            migrationBuilder.DropColumn(
                name: "Discription",
                table: "TwowheelerBrands");

            migrationBuilder.DropColumn(
                name: "EV",
                table: "TwowheelerBrands");

            migrationBuilder.DropColumn(
                name: "Petrol",
                table: "TwowheelerBrands");

            migrationBuilder.DropColumn(
                name: "TWVarientId",
                table: "TWMotorAndBatteries");

            migrationBuilder.DropColumn(
                name: "TWVarientId",
                table: "TWMileageAndPerformances");

            migrationBuilder.DropColumn(
                name: "TWVarientId",
                table: "TWFeatures");

            migrationBuilder.DropColumn(
                name: "TWVarientId",
                table: "TWEngineAndTransmissions");

            migrationBuilder.DropColumn(
                name: "TWVarientId",
                table: "TWElectricals");

            migrationBuilder.DropColumn(
                name: "TWVarientId",
                table: "TWDimensionsAndCapacities");

            migrationBuilder.DropColumn(
                name: "TWVarientId",
                table: "TWChassisAndSuspensions");

            migrationBuilder.DropColumn(
                name: "TWVarientId",
                table: "TWChargings");

            migrationBuilder.AddColumn<string>(
                name: "ABS",
                table: "TWUnderpinnings",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
