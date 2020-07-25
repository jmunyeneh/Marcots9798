using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MarcotsContactApp.Models
{
    public partial class MarcotsContext : DbContext
    {
        public MarcotsContext()
        {
        }

        public MarcotsContext(DbContextOptions<MarcotsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adddress> Adddress { get; set; }       
        public virtual DbSet<Days> Days { get; set; }
        public virtual DbSet<FamAddress> FamAddress { get; set; }
        public virtual DbSet<FamilyPhoto> FamilyPhoto { get; set; }
        public virtual DbSet<MarStatus> MarStatus { get; set; }
        public virtual DbSet<Months> Months { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=Marcots;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adddress>(entity =>
            {
                entity.HasKey(e => e.AddrId);

                entity.Property(e => e.AddrId).HasColumnName("AddrID");

                entity.Property(e => e.Address1).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.PostalCode).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);
            });

            //modelBuilder.Entity<ContactStatus>(entity =>
            //{
            //    entity.Property(e => e.ContactStatusDesc).HasMaxLength(50);
            //});

            modelBuilder.Entity<Days>(entity =>
            {
                entity.HasKey(e => e.DayId);

                entity.Property(e => e.DayId).HasColumnName("DayID");
            });

            modelBuilder.Entity<FamAddress>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddrId).HasColumnName("AddrID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.HasOne(d => d.Addr)
                    .WithMany(p => p.FamAddress)
                    .HasForeignKey(d => d.AddrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FamAddress_Adddress");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.FamAddress)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FamAddress_Person");
            });

            modelBuilder.Entity<FamilyPhoto>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PhotoId).HasColumnName("PhotoID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.FamilyPhoto)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_FamilyPhoto_Person");

                entity.HasOne(d => d.Photo)
                    .WithMany(p => p.FamilyPhoto)
                    .HasForeignKey(d => d.PhotoId)
                    .HasConstraintName("FK_FamilyPhoto_Photo");
            });

            modelBuilder.Entity<MarStatus>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Months>(entity =>
            {
                entity.HasKey(e => e.MonthId);

                entity.Property(e => e.MonthId).HasColumnName("MonthID");

                entity.Property(e => e.MonthName).HasMaxLength(50);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                //entity.Property(e => e.ContactStatusId).HasColumnName("ContactStatusID");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(40);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.InsertedDate).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MidName).HasMaxLength(3);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NickName).HasMaxLength(50);

                entity.Property(e => e.Occupation).HasMaxLength(100);

                entity.Property(e => e.OwnerId)
                    .HasColumnName("OwnerID")
                    .HasMaxLength(100);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Telephone).HasMaxLength(14);

                entity.HasOne(d => d.BirthDayNavigation)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.BirthDay)
                    .HasConstraintName("FK_Person_Days");

                entity.HasOne(d => d.BirthMonthNavigation)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.BirthMonth)
                    .HasConstraintName("FK_Person_Months");

                //entity.HasOne(d => d.ContactStatus)
                //    .WithMany(p => p.Person)
                //    .HasForeignKey(d => d.ContactStatusId)
                //    .HasConstraintName("FK_Person_ContactStatus");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Person_MarStatus");
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
