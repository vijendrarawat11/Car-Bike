using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars_Bikes.Migrations
{
    /// <inheritdoc />
    public partial class RenameTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TWChargings_Twowheelers_TwoWheelerId",
                table: "TWChargings");

            migrationBuilder.DropForeignKey(
                name: "FK_TWChassisAndSuspensions_Twowheelers_TwoWheelerId",
                table: "TWChassisAndSuspensions");

            migrationBuilder.DropForeignKey(
                name: "FK_TWDimensionsAndCapacities_Twowheelers_TwoWheelerId",
                table: "TWDimensionsAndCapacities");

            migrationBuilder.DropForeignKey(
                name: "FK_TWElectricals_Twowheelers_TwoWheelerId",
                table: "TWElectricals");

            migrationBuilder.DropForeignKey(
                name: "FK_TWEngineAndTransmissions_Twowheelers_TwoWheelerId",
                table: "TWEngineAndTransmissions");

            migrationBuilder.DropForeignKey(
                name: "FK_TWFeatures_Twowheelers_TwoWheelerId",
                table: "TWFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_TWMileageAndPerformances_Twowheelers_TwoWheelerId",
                table: "TWMileageAndPerformances");

            migrationBuilder.DropForeignKey(
                name: "FK_TWMotorAndBatteries_Twowheelers_TwoWheelerId",
                table: "TWMotorAndBatteries");

            migrationBuilder.DropForeignKey(
                name: "FK_Twowheelers_TwowheelerBrands_TwoWBrandId",
                table: "Twowheelers");

            migrationBuilder.DropForeignKey(
                name: "FK_TWSafety_Twowheelers_TwoWheelerId",
                table: "TWSafety");

            migrationBuilder.DropForeignKey(
                name: "FK_TWSpec_Twowheelers_TwoWheelerId",
                table: "TWSpec");

            migrationBuilder.DropForeignKey(
                name: "FK_TWTyresAndBrakes_Twowheelers_TwoWheelerId",
                table: "TWTyresAndBrakes");

            migrationBuilder.DropForeignKey(
                name: "FK_TWUnderpinnings_Twowheelers_TwoWheelerId",
                table: "TWUnderpinnings");

            migrationBuilder.DropForeignKey(
                name: "FK_TWVarients_Twowheelers_TwoWheelerId",
                table: "TWVarients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Twowheelers",
                table: "Twowheelers");

            migrationBuilder.RenameTable(
                name: "Twowheelers",
                newName: "TwoWheelers");

            migrationBuilder.RenameIndex(
                name: "IX_Twowheelers_TwoWBrandId",
                table: "TwoWheelers",
                newName: "IX_TwoWheelers_TwoWBrandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TwoWheelers",
                table: "TwoWheelers",
                column: "TwoWheelerId");

            migrationBuilder.AddForeignKey(
                name: "FK_TWChargings_TwoWheelers_TwoWheelerId",
                table: "TWChargings",
                column: "TwoWheelerId",
                principalTable: "TwoWheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TWChassisAndSuspensions_TwoWheelers_TwoWheelerId",
                table: "TWChassisAndSuspensions",
                column: "TwoWheelerId",
                principalTable: "TwoWheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TWDimensionsAndCapacities_TwoWheelers_TwoWheelerId",
                table: "TWDimensionsAndCapacities",
                column: "TwoWheelerId",
                principalTable: "TwoWheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TWElectricals_TwoWheelers_TwoWheelerId",
                table: "TWElectricals",
                column: "TwoWheelerId",
                principalTable: "TwoWheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TWEngineAndTransmissions_TwoWheelers_TwoWheelerId",
                table: "TWEngineAndTransmissions",
                column: "TwoWheelerId",
                principalTable: "TwoWheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TWFeatures_TwoWheelers_TwoWheelerId",
                table: "TWFeatures",
                column: "TwoWheelerId",
                principalTable: "TwoWheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TWMileageAndPerformances_TwoWheelers_TwoWheelerId",
                table: "TWMileageAndPerformances",
                column: "TwoWheelerId",
                principalTable: "TwoWheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TWMotorAndBatteries_TwoWheelers_TwoWheelerId",
                table: "TWMotorAndBatteries",
                column: "TwoWheelerId",
                principalTable: "TwoWheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TwoWheelers_TwowheelerBrands_TwoWBrandId",
                table: "TwoWheelers",
                column: "TwoWBrandId",
                principalTable: "TwowheelerBrands",
                principalColumn: "TWBrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_TWSafety_TwoWheelers_TwoWheelerId",
                table: "TWSafety",
                column: "TwoWheelerId",
                principalTable: "TwoWheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TWSpec_TwoWheelers_TwoWheelerId",
                table: "TWSpec",
                column: "TwoWheelerId",
                principalTable: "TwoWheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TWTyresAndBrakes_TwoWheelers_TwoWheelerId",
                table: "TWTyresAndBrakes",
                column: "TwoWheelerId",
                principalTable: "TwoWheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TWUnderpinnings_TwoWheelers_TwoWheelerId",
                table: "TWUnderpinnings",
                column: "TwoWheelerId",
                principalTable: "TwoWheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TWVarients_TwoWheelers_TwoWheelerId",
                table: "TWVarients",
                column: "TwoWheelerId",
                principalTable: "TwoWheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TWChargings_TwoWheelers_TwoWheelerId",
                table: "TWChargings");

            migrationBuilder.DropForeignKey(
                name: "FK_TWChassisAndSuspensions_TwoWheelers_TwoWheelerId",
                table: "TWChassisAndSuspensions");

            migrationBuilder.DropForeignKey(
                name: "FK_TWDimensionsAndCapacities_TwoWheelers_TwoWheelerId",
                table: "TWDimensionsAndCapacities");

            migrationBuilder.DropForeignKey(
                name: "FK_TWElectricals_TwoWheelers_TwoWheelerId",
                table: "TWElectricals");

            migrationBuilder.DropForeignKey(
                name: "FK_TWEngineAndTransmissions_TwoWheelers_TwoWheelerId",
                table: "TWEngineAndTransmissions");

            migrationBuilder.DropForeignKey(
                name: "FK_TWFeatures_TwoWheelers_TwoWheelerId",
                table: "TWFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_TWMileageAndPerformances_TwoWheelers_TwoWheelerId",
                table: "TWMileageAndPerformances");

            migrationBuilder.DropForeignKey(
                name: "FK_TWMotorAndBatteries_TwoWheelers_TwoWheelerId",
                table: "TWMotorAndBatteries");

            migrationBuilder.DropForeignKey(
                name: "FK_TwoWheelers_TwowheelerBrands_TwoWBrandId",
                table: "TwoWheelers");

            migrationBuilder.DropForeignKey(
                name: "FK_TWSafety_TwoWheelers_TwoWheelerId",
                table: "TWSafety");

            migrationBuilder.DropForeignKey(
                name: "FK_TWSpec_TwoWheelers_TwoWheelerId",
                table: "TWSpec");

            migrationBuilder.DropForeignKey(
                name: "FK_TWTyresAndBrakes_TwoWheelers_TwoWheelerId",
                table: "TWTyresAndBrakes");

            migrationBuilder.DropForeignKey(
                name: "FK_TWUnderpinnings_TwoWheelers_TwoWheelerId",
                table: "TWUnderpinnings");

            migrationBuilder.DropForeignKey(
                name: "FK_TWVarients_TwoWheelers_TwoWheelerId",
                table: "TWVarients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TwoWheelers",
                table: "TwoWheelers");

            migrationBuilder.RenameTable(
                name: "TwoWheelers",
                newName: "Twowheelers");

            migrationBuilder.RenameIndex(
                name: "IX_TwoWheelers_TwoWBrandId",
                table: "Twowheelers",
                newName: "IX_Twowheelers_TwoWBrandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Twowheelers",
                table: "Twowheelers",
                column: "TwoWheelerId");

            migrationBuilder.AddForeignKey(
                name: "FK_TWChargings_Twowheelers_TwoWheelerId",
                table: "TWChargings",
                column: "TwoWheelerId",
                principalTable: "Twowheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TWChassisAndSuspensions_Twowheelers_TwoWheelerId",
                table: "TWChassisAndSuspensions",
                column: "TwoWheelerId",
                principalTable: "Twowheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TWDimensionsAndCapacities_Twowheelers_TwoWheelerId",
                table: "TWDimensionsAndCapacities",
                column: "TwoWheelerId",
                principalTable: "Twowheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TWElectricals_Twowheelers_TwoWheelerId",
                table: "TWElectricals",
                column: "TwoWheelerId",
                principalTable: "Twowheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TWEngineAndTransmissions_Twowheelers_TwoWheelerId",
                table: "TWEngineAndTransmissions",
                column: "TwoWheelerId",
                principalTable: "Twowheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TWFeatures_Twowheelers_TwoWheelerId",
                table: "TWFeatures",
                column: "TwoWheelerId",
                principalTable: "Twowheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TWMileageAndPerformances_Twowheelers_TwoWheelerId",
                table: "TWMileageAndPerformances",
                column: "TwoWheelerId",
                principalTable: "Twowheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TWMotorAndBatteries_Twowheelers_TwoWheelerId",
                table: "TWMotorAndBatteries",
                column: "TwoWheelerId",
                principalTable: "Twowheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Twowheelers_TwowheelerBrands_TwoWBrandId",
                table: "Twowheelers",
                column: "TwoWBrandId",
                principalTable: "TwowheelerBrands",
                principalColumn: "TWBrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_TWSafety_Twowheelers_TwoWheelerId",
                table: "TWSafety",
                column: "TwoWheelerId",
                principalTable: "Twowheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TWSpec_Twowheelers_TwoWheelerId",
                table: "TWSpec",
                column: "TwoWheelerId",
                principalTable: "Twowheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TWTyresAndBrakes_Twowheelers_TwoWheelerId",
                table: "TWTyresAndBrakes",
                column: "TwoWheelerId",
                principalTable: "Twowheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TWUnderpinnings_Twowheelers_TwoWheelerId",
                table: "TWUnderpinnings",
                column: "TwoWheelerId",
                principalTable: "Twowheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TWVarients_Twowheelers_TwoWheelerId",
                table: "TWVarients",
                column: "TwoWheelerId",
                principalTable: "Twowheelers",
                principalColumn: "TwoWheelerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
