using Microsoft.EntityFrameworkCore.Migrations;

namespace TheRoom.Services.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PromoCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceID);
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ServiceID", "Description", "PromoCode" },
                values: new object[,]
                {
                    { 1, "Sitecostructor.io", "itpromocodes" },
                    { 2, "AppVision.com", "itpromocodes" },
                    { 3, "Analytics.com", "itpromocodes" },
                    { 4, "Logotype", "itpromocodes" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
