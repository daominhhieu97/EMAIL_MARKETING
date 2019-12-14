using Microsoft.EntityFrameworkCore.Migrations;

namespace EMAIL_MARKETING_THESIS_PROJECT.Migrations
{
    public partial class ChangeModelOfRFMSubscriber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FClass",
                table: "Subscriber");

            migrationBuilder.DropColumn(
                name: "MClass",
                table: "Subscriber");

            migrationBuilder.DropColumn(
                name: "RClass",
                table: "Subscriber");

            migrationBuilder.AddColumn<float>(
                name: "Frequency",
                table: "Subscriber",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Monetary",
                table: "Subscriber",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Recency",
                table: "Subscriber",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Frequency",
                table: "Subscriber");

            migrationBuilder.DropColumn(
                name: "Monetary",
                table: "Subscriber");

            migrationBuilder.DropColumn(
                name: "Recency",
                table: "Subscriber");

            migrationBuilder.AddColumn<string>(
                name: "FClass",
                table: "Subscriber",
                type: "nvarchar(MAX)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MClass",
                table: "Subscriber",
                type: "nvarchar(MAX)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RClass",
                table: "Subscriber",
                type: "nvarchar(MAX)",
                nullable: true);
        }
    }
}
