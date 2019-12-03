using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EMAIL_MARKETING_THESIS_PROJECT.Migrations
{
    public partial class ModifyNullableSendOnScheduler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "SendOn",
                table: "Scheduler",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "SendOn",
                table: "Scheduler",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);
        }
    }
}
