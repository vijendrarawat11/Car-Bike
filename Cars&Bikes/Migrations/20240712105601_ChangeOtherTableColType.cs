using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars_Bikes.Migrations
{
    /// <inheritdoc />
    public partial class ChangeOtherTableColType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TwoWheelers_TwowheelerBrands_TwoWBrandId",
                table: "TwoWheelers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UpcomingBikes",
                table: "UpcomingBikes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TwowheelerBrands",
                table: "TwowheelerBrands");

            migrationBuilder.RenameTable(
                name: "UpcomingBikes",
                newName: "TWUpcomingBikes");

            migrationBuilder.RenameTable(
                name: "TwowheelerBrands",
                newName: "TWBrands");

            migrationBuilder.AlterColumn<decimal>(
                name: "RearBrakeDiameter",
                table: "TWTyresAndBrakes",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FrontBrakeDiameter",
                table: "TWTyresAndBrakes",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Milage",
                table: "TWSpec",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FuelCapacity",
                table: "TWSpec",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OverallMileage",
                table: "TWMileageAndPerformances",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "HighwayMileage",
                table: "TWMileageAndPerformances",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CityMileage",
                table: "TWMileageAndPerformances",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ValvePerCylinder",
                table: "TWEngineAndTransmissions",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumOfCylinders",
                table: "TWEngineAndTransmissions",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Displacement",
                table: "TWEngineAndTransmissions",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Width",
                table: "TWDimensionsAndCapacities",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Wheelbase",
                table: "TWDimensionsAndCapacities",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "SaddleHeight",
                table: "TWDimensionsAndCapacities",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Length",
                table: "TWDimensionsAndCapacities",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "KerbWeight",
                table: "TWDimensionsAndCapacities",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Height",
                table: "TWDimensionsAndCapacities",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "GroundClearance",
                table: "TWDimensionsAndCapacities",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FuelReserve",
                table: "TWDimensionsAndCapacities",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FuelCapacity",
                table: "TWDimensionsAndCapacities",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TWUpcomingBikes",
                table: "TWUpcomingBikes",
                column: "UpcomingBikeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TWBrands",
                table: "TWBrands",
                column: "TWBrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_TwoWheelers_TWBrands_TwoWBrandId",
                table: "TwoWheelers",
                column: "TwoWBrandId",
                principalTable: "TWBrands",
                principalColumn: "TWBrandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TwoWheelers_TWBrands_TwoWBrandId",
                table: "TwoWheelers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TWUpcomingBikes",
                table: "TWUpcomingBikes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TWBrands",
                table: "TWBrands");

            migrationBuilder.RenameTable(
                name: "TWUpcomingBikes",
                newName: "UpcomingBikes");

            migrationBuilder.RenameTable(
                name: "TWBrands",
                newName: "TwowheelerBrands");

            migrationBuilder.AlterColumn<string>(
                name: "RearBrakeDiameter",
                table: "TWTyresAndBrakes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FrontBrakeDiameter",
                table: "TWTyresAndBrakes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Milage",
                table: "TWSpec",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FuelCapacity",
                table: "TWSpec",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OverallMileage",
                table: "TWMileageAndPerformances",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HighwayMileage",
                table: "TWMileageAndPerformances",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CityMileage",
                table: "TWMileageAndPerformances",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ValvePerCylinder",
                table: "TWEngineAndTransmissions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NumOfCylinders",
                table: "TWEngineAndTransmissions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Displacement",
                table: "TWEngineAndTransmissions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Width",
                table: "TWDimensionsAndCapacities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Wheelbase",
                table: "TWDimensionsAndCapacities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SaddleHeight",
                table: "TWDimensionsAndCapacities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Length",
                table: "TWDimensionsAndCapacities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KerbWeight",
                table: "TWDimensionsAndCapacities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Height",
                table: "TWDimensionsAndCapacities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GroundClearance",
                table: "TWDimensionsAndCapacities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FuelReserve",
                table: "TWDimensionsAndCapacities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FuelCapacity",
                table: "TWDimensionsAndCapacities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UpcomingBikes",
                table: "UpcomingBikes",
                column: "UpcomingBikeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TwowheelerBrands",
                table: "TwowheelerBrands",
                column: "TWBrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_TwoWheelers_TwowheelerBrands_TwoWBrandId",
                table: "TwoWheelers",
                column: "TwoWBrandId",
                principalTable: "TwowheelerBrands",
                principalColumn: "TWBrandId");
        }
    }
}
