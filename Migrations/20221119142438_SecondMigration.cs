using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Headless.DB.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Languages_LangId",
                table: "Pages");

            migrationBuilder.DropIndex(
                name: "IX_Pages_LangId",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "Body",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "LangId",
                table: "Pages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Body",
                table: "Pages",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "LangId",
                table: "Pages",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Pages_LangId",
                table: "Pages",
                column: "LangId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Languages_LangId",
                table: "Pages",
                column: "LangId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
