using Microsoft.EntityFrameworkCore.Migrations;

namespace EMAIL_MARKETING_THESIS_PROJECT.Migrations
{
    public partial class addSegmentEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SegmentId",
                table: "Subscriber",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Segment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MailingListId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(type: "nvarchar(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Segment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Segment_MailingList_MailingListId",
                        column: x => x.MailingListId,
                        principalTable: "MailingList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subscriber_SegmentId",
                table: "Subscriber",
                column: "SId");

            migrationBuilder.CreateIndex(
                name: "IX_Segment_MailingListId",
                table: "Segment",
                column: "MailingListId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriber_Segment_SegmentId",
                table: "Subscriber",
                column: "SegmentId",
                principalTable: "Segment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscriber_Segment_SegmentId",
                table: "Subscriber");

            migrationBuilder.DropTable(
                name: "Segment");

            migrationBuilder.DropIndex(
                name: "IX_Subscriber_SegmentId",
                table: "Subscriber");

            migrationBuilder.DropColumn(
                name: "SegmentId",
                table: "Subscriber");
        }
    }
}