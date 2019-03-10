using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReposirotyPatternDemo.Migrations
{
    public partial class DKBSDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<decimal>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    OrderName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Partners",
                columns: table => new
                {
                    PartnerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PartnerName = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners", x => x.PartnerId);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Name", "OrderName" },
                values: new object[,]
                {
                    { 100m, "Hindustan Liver", "Dettol" },
                    { 101m, "Emami", "Savlon" },
                    { 102m, "Boro Plus", "Sheeter" }
                });

            migrationBuilder.InsertData(
                table: "Partners",
                columns: new[] { "PartnerId", "PartnerName", "ZipCode" },
                values: new object[,]
                {
                    { 200, "White feather", 482001 },
                    { 201, "Blak Panther", 144211 },
                    { 202, "Hinduja", 560076 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Partners");
        }
    }
}
