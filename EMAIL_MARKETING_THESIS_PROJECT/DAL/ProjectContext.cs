using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMAIL_MARKETING_THESIS_PROJECT.DAL
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options ) : base(options)
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
        }

        private void MapCampaign(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Campaign>();

            entity.HasKey(camp => camp.Id);
            entity.Property(camp => camp.Id).ValueGeneratedOnAdd();

            entity.Property(camp => camp.Title)
                .HasColumnType("nvarchar")
                .HasMaxLength(256);

            entity.HasOne(camp => camp.Email).WithOne(email => email.Campaign);
            entity.HasOne(camp => camp.Scheduler).WithOne(scheduler => scheduler.Campaign);
        }

        private void MapEmailTemplate(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<EmailTemplate>();

            entity.HasKey(email => email.Id);
            entity.Property(email => email.Id).ValueGeneratedOnAdd();

            entity.Property(email => email.Receiver).HasMaxLength(256).HasColumnType("nvarchar").IsRequired(true);
            entity.Property(email => email.Subject).HasMaxLength(256).HasColumnType("nvarchar").IsRequired(true);
            entity.Property(email => email.Sender).HasMaxLength(256).HasColumnType("nvarchar").IsRequired(true);
        }

        private void MapMailingList(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<MailingList>();

            entity.HasKey(m => m.Id);
            entity.Property(m => m.Id).ValueGeneratedOnAdd();
            entity.Property(m => m.Title).HasMaxLength(256).HasColumnType("nvarchar").IsRequired(true);
        }

        private void MapScheduler(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Scheduler>();

            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IsSendNow).HasColumnType("bit");
            entity.Property(e => e.SendOn).HasColumnType("datetime");
            entity.HasOne(e => e.Campaign).WithOne(c => c.Scheduler);
        }

        private void MapTemplate(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Template>();

            entity.HasKey(e => e.TemplateId);
            entity.Property(e => e.TemplateId).ValueGeneratedOnAdd();
            entity.Property(e => e.Content).HasColumnType("byte").IsRequired();            
        }

        private void MapCustomer(ModelBuilder modelBuilder)
        {
        }

        private void MapSubsciber(ModelBuilder modelBuilder)
        {
            throw new NotImplementedException();
        }
    }
}
