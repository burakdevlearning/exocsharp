using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Bmail.Model
{
    public partial class BmailContext : DbContext
    {
        public BmailContext()
        {
        }

        public BmailContext(DbContextOptions<BmailContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Campaign> Campaign { get; set; }
        public virtual DbSet<Email> Email { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(System.Configuration.ConfigurationManager.ConnectionStrings["BmailConnectionString"].ToString());

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Campaign>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Email>(entity =>
            {
                entity.Property(e => e.Attachments)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Format).HasMaxLength(20);

                entity.Property(e => e.Receiver)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Sender)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.Email)
                    .HasForeignKey(d => d.CampaignId)
                    .HasConstraintName("FK__Email__CampaignI__145C0A3F");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
