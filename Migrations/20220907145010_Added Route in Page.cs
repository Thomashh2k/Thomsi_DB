using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Headless.DB.Migrations
{
    public partial class AddedRouteinPage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Route",
                table: "Pages",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Route",
                table: "Pages");
        }
    }
}
