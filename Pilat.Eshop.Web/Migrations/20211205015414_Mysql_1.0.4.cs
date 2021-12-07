using Microsoft.EntityFrameworkCore.Migrations;

namespace Pilat.Eshop.Web.Migrations
{
    public partial class Mysql_104 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Related",
                table: "Products",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Related",
                table: "Products");
        }
    }
}
