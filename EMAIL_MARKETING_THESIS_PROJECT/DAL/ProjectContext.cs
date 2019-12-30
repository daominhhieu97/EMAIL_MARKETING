using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Customer;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using Microsoft.EntityFrameworkCore;

namespace EMAIL_MARKETING_THESIS_PROJECT.DAL
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            MapCampaign(modelBuilder);
            MapEmailTemplate(modelBuilder);
            MapMailingList(modelBuilder);
            MapScheduler(modelBuilder);
            MapTemplate(modelBuilder);
            MapCustomer(modelBuilder);
            MapSubsciber(modelBuilder);
            MapRFMSubscriber(modelBuilder);
            MapMailingListSubscriber(modelBuilder);
        }

        private void MapMailingListSubscriber(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<MailingListSubscriber>();

            entity.HasKey(e => new { e.MailingListId, e.SubscriberId });

            entity.HasOne(ms => ms.MailingList)
                .WithMany(m => m.SubscribersLink)
                .HasForeignKey(ms => ms.MailingListId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(ms => ms.Subscriber)
                .WithMany(ml => ml.MailingListsLink)
                .HasForeignKey(ms => ms.SubscriberId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        private void MapRFMSubscriber(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<RFMSubscriber>();

            entity.Property(e => e.RFMClass).HasColumnType("nvarchar(MAX)");
        }

        private void MapCampaign(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Campaign>();

            entity.HasKey(camp => camp.Id);
            entity.Property(camp => camp.Id).ValueGeneratedOnAdd();

            entity.Property(camp => camp.Title)
                .HasColumnType("nvarchar(MAX)");

            entity.HasOne(camp => camp.EmailInfo).WithOne(email => email.Campaign).HasForeignKey<EmailTemplate>(e => e.CampaignId);

            entity.HasOne(camp => camp.Scheduler).WithOne(scheduler => scheduler.Campaign).HasForeignKey<Scheduler>(s => s.CampaignId);
        }

        private void MapEmailTemplate(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<EmailTemplate>();

            entity.HasKey(email => email.Id);
            entity.Property(email => email.Id).ValueGeneratedOnAdd();

            entity.Property(email => email.Subject)
                .HasColumnType("nvarchar(MAX)")
                .IsRequired();

            entity.Property(e => e.Sender)
                .HasColumnType("nvarchar(MAX)")
                .IsRequired();

            entity.Property(e => e.Name)
                .HasColumnType("nvarchar(MAX)")
                .IsRequired();
        }

        private void MapMailingList(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<MailingList>();

            entity.HasKey(m => m.Id);
            entity.Property(m => m.Id).ValueGeneratedOnAdd();
            entity.Property(m => m.Title)
                .HasColumnType("nvarchar(MAX)")
                .IsRequired(true);
        }

        private void MapScheduler(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Scheduler>();

            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IsSendNow).HasColumnType("bit");
            entity.Property(e => e.SendOn).HasColumnType("datetime");
        }

        private void MapTemplate(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Template>();

            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name)
                .HasColumnType("nvarchar(256)")
                .IsRequired();
        }

        private void MapCustomer(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Customer>();

            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Username)
                .HasColumnType("nvarchar(MAX)")
                .IsRequired();
            entity.Property(e => e.Password)
                .HasColumnType("nvarchar(MAX)")
                .IsRequired();
            entity.Property(e => e.Name)
                .HasColumnType("nvarchar(MAX)")
                .IsRequired();
        }

        private void MapSubsciber(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Subscriber>();

            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Email)
                .HasColumnType("nvarchar(MAX)")
                .IsRequired();

            entity.Property(e => e.Phone)
                .HasColumnType("nvarchar(MAX)");

            entity.Property(e => e.Name)
                .HasColumnType("nvarchar(MAX)");

            entity.Property(e => e.City)
                .HasColumnType("nvarchar(MAX)");

            entity.Property(e => e.Area)
                .HasColumnType("nvarchar(MAX)");

            entity.Property(e => e.Age)
                .HasColumnType("int");
        }

        public DbSet<EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns.Campaign> Campaign { get; set; }

        public DbSet<EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns.Template> Template { get; set; }
    }
}