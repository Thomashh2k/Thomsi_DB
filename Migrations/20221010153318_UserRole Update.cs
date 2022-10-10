using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Headless.DB.Migrations
{
    public partial class UserRoleUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorAccess",
                table: "AspNetRoles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuthorRolesAccess",
                table: "AspNetRoles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomFormAccess",
                table: "AspNetRoles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetRoles",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "LangAccess",
                table: "AspNetRoles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PageAccess",
                table: "AspNetRoles",
                type: "integer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorAccess",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "AuthorRolesAccess",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "CustomFormAccess",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "LangAccess",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "PageAccess",
                table: "AspNetRoles");
        }
    }
}
