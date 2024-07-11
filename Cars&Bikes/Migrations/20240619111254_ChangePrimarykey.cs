using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars_Bikes.Migrations
{
    /// <inheritdoc />
    public partial class ChangePrimarykey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Twowheelers",
                table: "Twowheelers");

            migrationBuilder.AlterColumn<string>(
                name: "TwoWheelerName",
                table: "Twowheelers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Twowheelers",
                table: "Twowheelers",
                column: "TwoWheelerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Twowheelers",
                table: "Twowheelers");

            migrationBuilder.AlterColumn<string>(
                name: "TwoWheelerName",
                table: "Twowheelers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Twowheelers",
                table: "Twowheelers",
                column: "TwoWheelerName");
        }
    }
}
