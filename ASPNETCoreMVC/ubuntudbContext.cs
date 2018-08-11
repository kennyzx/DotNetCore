using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ASPNETCoreMVC
{
    public partial class ubuntudbContext : DbContext
    {
        public ubuntudbContext()
        {
        }

        public ubuntudbContext(DbContextOptions<ubuntudbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Installations> Installations { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Versions> Versions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=localhost;Database=ubuntudb;User=ubuntudbuser;Password=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Installations>(entity =>
            {
                entity.ToTable("installations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Installationdate)
                    .HasColumnName("installationdate")
                    .HasColumnType("date");

                entity.Property(e => e.Userdomain)
                    .IsRequired()
                    .HasColumnName("userdomain")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("version")
                    .HasColumnType("varchar(35)");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("users");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Emailaddress)
                    .HasColumnName("emailaddress")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<Versions>(entity =>
            {
                entity.HasKey(e => e.Version);

                entity.ToTable("versions");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasColumnType("varchar(35)");

                entity.Property(e => e.Releasedate)
                    .HasColumnName("releasedate")
                    .HasColumnType("date");
            });
        }
    }
}
