using Microsoft.EntityFrameworkCore.Migrations;

namespace EMAIL_MARKETING_THESIS_PROJECT.Migrations
{
    public partial class temp1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Path",
                table: "Template");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Template",
                type: "nvarchar(MAX)",
                nullable: true);
        }
    }
}
