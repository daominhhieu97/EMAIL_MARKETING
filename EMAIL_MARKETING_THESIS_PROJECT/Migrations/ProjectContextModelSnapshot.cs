﻿// <auto-generated />
using System;
using EMAIL_MARKETING_THESIS_PROJECT.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EMAIL_MARKETING_THESIS_PROJECT.Migrations
{
    [DbContext(typeof(ProjectContext))]
    partial class ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns.Campaign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MailingListId")
                        .HasColumnType("int");

                    b.Property<int?>("SegmentId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(MAX)");

                    b.HasKey("Id");

                    b.HasIndex("MailingListId");

                    b.ToTable("Campaign");
                });

            modelBuilder.Entity("EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns.EmailTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CampaignId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Sender")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int?>("TemplateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CampaignId")
                        .IsUnique();

                    b.HasIndex("TemplateId");

                    b.ToTable("EmailTemplate");
                });

            modelBuilder.Entity("EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns.MailingList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.HasKey("Id");

                    b.ToTable("MailingList");
                });

            modelBuilder.Entity("EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns.Scheduler", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CampaignId")
                        .HasColumnType("int");

                    b.Property<bool>("IsSendNow")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("SendOn")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("CampaignId")
                        .IsUnique();

                    b.ToTable("Scheduler");
                });

            modelBuilder.Entity("EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns.Segment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MailingListId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.HasKey("Id");

                    b.HasIndex("MailingListId");

                    b.ToTable("Segment");
                });

            modelBuilder.Entity("EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns.Template", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Template");
                });

            modelBuilder.Entity("EMAIL_MARKETING_THESIS_PROJECT.Models.Customer.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers.MailingListSubscriber", b =>
                {
                    b.Property<int>("MailingListId")
                        .HasColumnType("int");

                    b.Property<int>("SubscriberId")
                        .HasColumnType("int");

                    b.HasKey("MailingListId", "SubscriberId");

                    b.HasIndex("SubscriberId");

                    b.ToTable("MailingListSubscriber");
                });

            modelBuilder.Entity("EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers.Subscriber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(MAX)");

                    b.HasKey("Id");

                    b.ToTable("Subscriber");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Subscriber");
                });

            modelBuilder.Entity("EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers.RFMSubscriber", b =>
                {
                    b.HasBaseType("EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers.Subscriber");

                    b.Property<float?>("Frequency")
                        .HasColumnType("real");

                    b.Property<float?>("Monetary")
                        .HasColumnType("real");

                    b.Property<string>("RFMClass")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<float?>("Recency")
                        .HasColumnType("real");

                    b.Property<int?>("SegmentId")
                        .HasColumnType("int");

                    b.HasIndex("SegmentId");

                    b.HasDiscriminator().HasValue("RFMSubscriber");
                });

            modelBuilder.Entity("EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns.Campaign", b =>
                {
                    b.HasOne("EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns.MailingList", "MailingList")
                        .WithMany()
                        .HasForeignKey("MailingListId");
                });

            modelBuilder.Entity("EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns.EmailTemplate", b =>
                {
                    b.HasOne("EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns.Campaign", "Campaign")
                        .WithOne("EmailInfo")
                        .HasForeignKey("EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns.EmailTemplate", "CampaignId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns.Template", "Template")
                        .WithMany()
                        .HasForeignKey("TemplateId");
                });

            modelBuilder.Entity("EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns.Scheduler", b =>
                {
                    b.HasOne("EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns.Campaign", "Campaign")
                        .WithOne("Scheduler")
                        .HasForeignKey("EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns.Scheduler", "CampaignId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns.Segment", b =>
                {
                    b.HasOne("EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns.MailingList", "MailingList")
                        .WithMany("Segments")
                        .HasForeignKey("MailingListId");
                });

            modelBuilder.Entity("EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers.MailingListSubscriber", b =>
                {
                    b.HasOne("EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns.MailingList", "MailingList")
                        .WithMany("SubscribersLink")
                        .HasForeignKey("MailingListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers.RFMSubscriber", "Subscriber")
                        .WithMany("MailingListsLink")
                        .HasForeignKey("SubscriberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers.RFMSubscriber", b =>
                {
                    b.HasOne("EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns.Segment", null)
                        .WithMany("Subscribers")
                        .HasForeignKey("SegmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
