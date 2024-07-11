using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars_Bikes.Migrations
{
    /// <inheritdoc />
    public partial class AddTWLatestNews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TWLatestNews",
                columns: table => new
                {
                    TWLatestNewsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsHeading = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NewsSummary = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    NewsDetail = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TWLatestNews", x => x.TWLatestNewsId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TWLatestNews");
        }
    }
}
