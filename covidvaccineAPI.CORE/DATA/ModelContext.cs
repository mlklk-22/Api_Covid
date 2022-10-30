using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace covidvaccineAPI.CORE.Data
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Testmonial> Testmonials { get; set; }
        public virtual DbSet<Useraccount> Useraccounts { get; set; }
        public virtual DbSet<VacCenter> VacCenters { get; set; }
        public virtual DbSet<Vaccinationcenter> Vaccinationcenters { get; set; }
        public virtual DbSet<Vaccine> Vaccines { get; set; }
        public virtual DbSet<Vaccinehistory> Vaccinehistories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("USER ID=TAH14_User60;PASSWORD=Test321;DATA SOURCE=94.56.229.181:3488/traindb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TAH14_USER60")
                .HasAnnotation("Relational:Collation", "USING_NLS_COMP");

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.HasKey(e => e.Reserveid)
                    .HasName("SYS_C00300997");

                entity.ToTable("RESERVATION");

                entity.Property(e => e.Reserveid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RESERVEID");

                entity.Property(e => e.Actualdatedose1)
                    .HasColumnType("DATE")
                    .HasColumnName("ACTUALDATEDOSE1");

                entity.Property(e => e.Actualdatedose2)
                    .HasColumnType("DATE")
                    .HasColumnName("ACTUALDATEDOSE2");

                entity.Property(e => e.Centerid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CENTERID");

                entity.Property(e => e.Idvaccinehistory)
                    .HasColumnType("NUMBER")
                    .HasColumnName("IDVACCINEHISTORY");

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USERID");

                entity.Property(e => e.Vaccineid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("VACCINEID");

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.Centerid)
                    .HasConstraintName("SYS_C00301000");

                entity.HasOne(d => d.IdvaccinehistoryNavigation)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.Idvaccinehistory)
                    .HasConstraintName("SYS_C00301050");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("SYS_C00300998");

                entity.HasOne(d => d.Vaccine)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.Vaccineid)
                    .HasConstraintName("SYS_C00300999");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("ROLES");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Rolename)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ROLENAME");
            });

            modelBuilder.Entity<Testmonial>(entity =>
            {
                entity.HasKey(e => e.Idtest)
                    .HasName("SYS_C00300848");

                entity.ToTable("TESTMONIAL");

                entity.Property(e => e.Idtest)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTEST");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGE");

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Testmonials)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("SYS_C00300849");
            });

            modelBuilder.Entity<Useraccount>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("SYS_C00300703");

                entity.ToTable("USERACCOUNT");

                entity.HasIndex(e => e.Email, "EMAIL_UK")
                    .IsUnique();

                entity.HasIndex(e => e.Username, "USERNAME_UK")
                    .IsUnique();

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("USERID");

                entity.Property(e => e.Age)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AGE");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Image)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE");

                entity.Property(e => e.Numberofvaccines)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NUMBEROFVACCINES");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Phonenumber)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PHONENUMBER");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Useraccounts)
                    .HasForeignKey(d => d.Roleid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("ROLEFKK");
            });

            modelBuilder.Entity<VacCenter>(entity =>
            {
                entity.ToTable("VAC_CENTER");

                entity.Property(e => e.VacCenterid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("VAC_CENTERID");

                entity.Property(e => e.Centerid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CENTERID");

                entity.Property(e => e.Vaccineid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("VACCINEID");

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.VacCenters)
                    .HasForeignKey(d => d.Centerid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("VAC_CENTER");

                entity.HasOne(d => d.Vaccine)
                    .WithMany(p => p.VacCenters)
                    .HasForeignKey(d => d.Vaccineid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_VAC");
            });

            modelBuilder.Entity<Vaccinationcenter>(entity =>
            {
                entity.HasKey(e => e.Centerid)
                    .HasName("SYS_C00300987");

                entity.ToTable("VACCINATIONCENTER");

                entity.Property(e => e.Centerid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CENTERID");

                entity.Property(e => e.Centeraddres)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CENTERADDRES");

                entity.Property(e => e.Centername)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CENTERNAME");

                entity.Property(e => e.Centerusercapacity)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CENTERUSERCAPACITY");

                entity.Property(e => e.Centervaccinecapacity)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CENTERVACCINECAPACITY");

                entity.Property(e => e.VacCenterid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("VAC_CENTERID");

                entity.HasOne(d => d.VacCenter)
                    .WithMany(p => p.Vaccinationcenters)
                    .HasForeignKey(d => d.VacCenterid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_VAC_VACCENTER");
            });

            modelBuilder.Entity<Vaccine>(entity =>
            {
                entity.ToTable("VACCINES");

                entity.Property(e => e.Vaccineid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("VACCINEID");

                entity.Property(e => e.VacCenterid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("VAC_CENTERID");

                entity.Property(e => e.Vaccinedoses)
                    .HasColumnType("NUMBER")
                    .HasColumnName("VACCINEDOSES");

                entity.Property(e => e.Vaccineexp)
                    .HasColumnType("DATE")
                    .HasColumnName("VACCINEEXP");

                entity.Property(e => e.Vaccinename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VACCINENAME");

                entity.HasOne(d => d.VacCenter)
                    .WithMany(p => p.Vaccines)
                    .HasForeignKey(d => d.VacCenterid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_VAC_CENTER");
            });

            modelBuilder.Entity<Vaccinehistory>(entity =>
            {
                entity.ToTable("VACCINEHISTORY");

                entity.Property(e => e.Vaccinehistoryid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("VACCINEHISTORYID");

                entity.Property(e => e.Reserveid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESERVEID");

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USERID");

                entity.HasOne(d => d.Reserve)
                    .WithMany(p => p.Vaccinehistories)
                    .HasForeignKey(d => d.Reserveid)
                    .HasConstraintName("SYS_C00301049");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Vaccinehistories)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("SYS_C00301048");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
