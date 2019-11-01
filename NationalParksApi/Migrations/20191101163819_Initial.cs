using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParksApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "A beautiful little park.", "Wyoming", "Yellow Stone" },
                    { 2, "Big 'Ol Deep Clear Lake", "Oregon", "Crater Lake" },
                    { 3, "Big 'Ol Mountain", "California", "Big Bear" },
                    { 4, "Big 'Ol crack in the ground", "Nevada", "Grand Canyon" },
                    { 5, "Big Ol Trees", "California", "Jedidiah Smith RedWoods" },
                    { 6, "Dirty Ol Water", "Florida", "EverGlades" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
