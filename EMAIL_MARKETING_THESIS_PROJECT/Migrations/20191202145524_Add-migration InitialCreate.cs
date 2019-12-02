using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EMAIL_MARKETING_THESIS_PROJECT.Migrations
{
    public partial class AddmigrationInitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MailingList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailingList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscriber",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Area = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    RClass = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    FClass = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    MClass = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    RFMClass = table.Column<string>(type: "nvarchar(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriber", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Template",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    Content = table.Column<byte[]>(type: "VARBINARY(8000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Template", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Campaign",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    MailingListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaign", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Campaign_MailingList_MailingListId",
                        column: x => x.MailingListId,
                        principalTable: "MailingList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MailingListSubscriber",
                columns: table => new
                {
                    MailingListId = table.Column<int>(nullable: false),
                    SubscriberId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailingListSubscriber", x => new { x.MailingListId, x.SubscriberId });
                    table.ForeignKey(
                        name: "FK_MailingListSubscriber_MailingList_MailingListId",
                        column: x => x.MailingListId,
                        principalTable: "MailingList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MailingListSubscriber_Subscriber_SubscriberId",
                        column: x => x.SubscriberId,
                        principalTable: "Subscriber",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Sender = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    TemplateId = table.Column<int>(nullable: true),
                    CampaignId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTemplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailTemplate_Campaign_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaign",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmailTemplate_Template_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "Template",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Scheduler",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsSendNow = table.Column<bool>(type: "bit", nullable: false),
                    SendOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    CampaignId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scheduler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Scheduler_Campaign_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaign",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Campaign_MailingListId",
                table: "Campaign",
                column: "MailingListId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplate_CampaignId",
                table: "EmailTemplate",
                column: "CampaignId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplate_TemplateId",
                table: "EmailTemplate",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_MailingListSubscriber_SubscriberId",
                table: "MailingListSubscriber",
                column: "SubscriberId");

            migrationBuilder.CreateIndex(
                name: "IX_Scheduler_CampaignId",
                table: "Scheduler",
                column: "CampaignId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "EmailTemplate");

            migrationBuilder.DropTable(
                name: "MailingListSubscriber");

            migrationBuilder.DropTable(
                name: "Scheduler");

            migrationBuilder.DropTable(
                name: "Template");

            migrationBuilder.DropTable(
                name: "Subscriber");

            migrationBuilder.DropTable(
                name: "Campaign");

            migrationBuilder.DropTable(
                name: "MailingList");
        }
    }
}
