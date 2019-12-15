using Microsoft.EntityFrameworkCore.Migrations;

namespace EMAIL_MARKETING_THESIS_PROJECT.Migrations
{
    public partial class AddContentToTemplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Template",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Template");
        }
    }
}
