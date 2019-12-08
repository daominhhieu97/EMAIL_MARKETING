using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EMAIL_MARKETING_THESIS_PROJECT.Migrations
{
    public partial class removeContentOfTemplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Template");

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Template",
                type: "nvarchar(MAX)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Path",
                table: "Template");

            migrationBuilder.AddColumn<byte[]>(
                name: "Content",
                table: "Template",
                type: "VARBINARY(8000)",
                nullable: true);
        }
    }
}
