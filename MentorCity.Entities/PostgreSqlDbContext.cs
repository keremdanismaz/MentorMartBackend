using MentorCity.Entities.Entities;
using MentorCity.Entities.Seeder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorCity.Entities
{
    public class PostgreSqlDbContext : DbContext
    {
        public PostgreSqlDbContext(DbContextOptions<PostgreSqlDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PostgreSqlDbContext).Assembly);

            // CorporationInfo table Configurations
            modelBuilder.Entity<CorporationInfo>().Property(s => s.CorporationInfoText).HasMaxLength(1000).IsRequired(true);

            // Meeting table Configurations
            modelBuilder.Entity<Meeting>().Property(s => s.MeetingTopic).HasMaxLength(300).IsRequired(true);
            modelBuilder.Entity<Meeting>().Property(s => s.MeetingLink).HasMaxLength(200).IsRequired(true);
            modelBuilder.Entity<Meeting>()
                   .HasOne(r => r.Mentor)
                   .WithMany()
                   .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Meeting>()
               .HasOne(r => r.Mentee)
               .WithMany()
               .OnDelete(DeleteBehavior.Restrict);

            // Note table Configurations
            modelBuilder.Entity<Note>().Property(s => s.NoteTitle).HasMaxLength(300).IsRequired(true);
            modelBuilder.Entity<Note>().Property(s => s.NoteLinkName).HasMaxLength(200).IsRequired(true);
            modelBuilder.Entity<Note>().Property(s => s.NoteLink).HasMaxLength(200).IsRequired(true);
            modelBuilder.Entity<Note>()
                     .HasOne(r => r.Mentor)
                     .WithMany()
                     .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Note>()
               .HasOne(r => r.Mentee)
               .WithMany()
               .OnDelete(DeleteBehavior.Restrict);

            // Question table Configurations
            modelBuilder.Entity<Question>().Property(s => s.AskQuestion).HasMaxLength(400).IsRequired(true);
            modelBuilder.Entity<Question>()
                   .HasOne(r => r.Mentor)
                   .WithMany()
                   .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Question>()
               .HasOne(r => r.Mentee)
               .WithMany()
               .OnDelete(DeleteBehavior.Restrict);

            // User table Configurations
            modelBuilder.Entity<User>().Property(s => s.FirstName).HasMaxLength(20).IsRequired(true);
            modelBuilder.Entity<User>().Property(s => s.LastName).HasMaxLength(20).IsRequired(true);
            modelBuilder.Entity<User>().Property(s => s.Password).HasMaxLength(400).IsRequired(true);
            modelBuilder.Entity<User>().Property(s => s.Mail).HasMaxLength(300).IsRequired(true);
            modelBuilder.Entity<User>().Property(s => s.About).HasMaxLength(500).IsRequired(false);
            modelBuilder.Entity<User>().Property(s => s.Address).HasMaxLength(300).IsRequired(false);

            // Seeders
            CorporationDataSeeder.Run(modelBuilder);
            RoleDataSeeder.Run(modelBuilder);
            MeetingLocationDataSeeder.Run(modelBuilder);
            UserDataSeeder.Run(modelBuilder);
            CorporationInfoDataSeeder.Run(modelBuilder);
        }

        public DbSet<CorporationInfo> CorporationInfos { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Corporation> Corporations { get; set; }
        public DbSet<MeetingLocation> MeetingLocations { get; set; }
    }
}