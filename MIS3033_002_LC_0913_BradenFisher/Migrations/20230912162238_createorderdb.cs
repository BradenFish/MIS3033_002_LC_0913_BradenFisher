using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MIS3033_002_LC_0913_BradenFisher.Migrations
{
    /// <inheritdoc />
    public partial class createorderdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ordersTbl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QtyApple = table.Column<double>(type: "REAL", nullable: false),
                    QtyBananas = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordersTbl", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ordersTbl");
        }
    }
}
