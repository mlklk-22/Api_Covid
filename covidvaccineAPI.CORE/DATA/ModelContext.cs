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

        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<Footer> Footers { get; set; }
        public virtual DbSet<Home> Homes { get; set; }
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

            modelBuilder.Entity<About>(entity =>
            {
                entity.ToTable("ABOUT");

                entity.Property(e => e.Aboutid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ABOUTID");

                entity.Property(e => e.Descprotect)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DESCPROTECT");

                entity.Property(e => e.Descriptiontitle1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTIONTITLE1");

                entity.Property(e => e.Imagetitle1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IMAGETITLE1");

                entity.Property(e => e.Littleprotecttitle)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("LITTLEPROTECTTITLE");

                entity.Property(e => e.Littletitle1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("LITTLETITLE1");

                entity.Property(e => e.Point1desc1)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("POINT1DESC1");

                entity.Property(e => e.Point1desc2)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("POINT1DESC2");

                entity.Property(e => e.Point1desc3)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("POINT1DESC3");

                entity.Property(e => e.Point2desc1)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("POINT2DESC1");

                entity.Property(e => e.Point2desc2)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("POINT2DESC2");

                entity.Property(e => e.Point2desc3)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("POINT2DESC3");

                entity.Property(e => e.Protectimage)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PROTECTIMAGE");

                entity.Property(e => e.Protectpoint1)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PROTECTPOINT1");

                entity.Property(e => e.Protectpoint2)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PROTECTPOINT2");

                entity.Property(e => e.Protecttitle)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PROTECTTITLE");

                entity.Property(e => e.Textbuttontitle1)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TEXTBUTTONTITLE1");

                entity.Property(e => e.Title1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TITLE1");

                entity.Property(e => e.Whatdesc1)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("WHATDESC1");

                entity.Property(e => e.Whatdesc2)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("WHATDESC2");

                entity.Property(e => e.Whatdesc3)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("WHATDESC3");

                entity.Property(e => e.Whatdescription)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("WHATDESCRIPTION");

                entity.Property(e => e.Whatimage)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("WHATIMAGE");

                entity.Property(e => e.Whattextbutton)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("WHATTEXTBUTTON");

                entity.Property(e => e.Whattitle)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("WHATTITLE");
            });

            modelBuilder.Entity<Footer>(entity =>
            {
                entity.ToTable("FOOTER");

                entity.Property(e => e.Footerid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("FOOTERID");

                entity.Property(e => e.Desctitle2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DESCTITLE2");

                entity.Property(e => e.Link1title1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LINK1TITLE1");

                entity.Property(e => e.Link1title3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LINK1TITLE3");

                entity.Property(e => e.Link1title4)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LINK1TITLE4");

                entity.Property(e => e.Link2title1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LINK2TITLE1");

                entity.Property(e => e.Link2title3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LINK2TITLE3");

                entity.Property(e => e.Link2title4)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LINK2TITLE4");

                entity.Property(e => e.Link3title1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LINK3TITLE1");

                entity.Property(e => e.Link3title3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LINK3TITLE3");

                entity.Property(e => e.Link3title4)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LINK3TITLE4");

                entity.Property(e => e.Link4title1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LINK4TITLE1");

                entity.Property(e => e.Link4title3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LINK4TITLE3");

                entity.Property(e => e.Link4title4)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LINK4TITLE4");

                entity.Property(e => e.Title1)
                    .HasMaxLength(155)
                    .IsUnicode(false)
                    .HasColumnName("TITLE1");

                entity.Property(e => e.Title2)
                    .HasMaxLength(155)
                    .IsUnicode(false)
                    .HasColumnName("TITLE2");

                entity.Property(e => e.Title3)
                    .HasMaxLength(155)
                    .IsUnicode(false)
                    .HasColumnName("TITLE3");

                entity.Property(e => e.Title4)
                    .HasMaxLength(155)
                    .IsUnicode(false)
                    .HasColumnName("TITLE4");
            });

            modelBuilder.Entity<Home>(entity =>
            {
                entity.ToTable("HOME");

                entity.Property(e => e.Homeid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("HOMEID");

                entity.Property(e => e.Desc1statistics)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DESC1STATISTICS");

                entity.Property(e => e.Desc2statistics)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DESC2STATISTICS");

                entity.Property(e => e.Desc3statistics)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DESC3STATISTICS");

                entity.Property(e => e.Descriptionstatistics)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTIONSTATISTICS");

                entity.Property(e => e.Descriptiontitle1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTIONTITLE1");

                entity.Property(e => e.Imagelogo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IMAGELOGO");

                entity.Property(e => e.Imagetitle1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IMAGETITLE1");

                entity.Property(e => e.Littletitle1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("LITTLETITLE1");

                entity.Property(e => e.Newsdesc1)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("NEWSDESC1");

                entity.Property(e => e.Newsdesc2)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("NEWSDESC2");

                entity.Property(e => e.Newsdesc3)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("NEWSDESC3");

                entity.Property(e => e.Newsimage1)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("NEWSIMAGE1");

                entity.Property(e => e.Newsimage2)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("NEWSIMAGE2");

                entity.Property(e => e.Newsimage3)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("NEWSIMAGE3");

                entity.Property(e => e.Newstitle)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("NEWSTITLE");

                entity.Property(e => e.Statisticstitle)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("STATISTICSTITLE");

                entity.Property(e => e.Textbutton)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TEXTBUTTON");

                entity.Property(e => e.Title1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TITLE1");
            });

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

                entity.Property(e => e.Massage)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("MASSAGE");

                entity.Property(e => e.Status)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USERID");

                entity.Property(e => e.Vaccineid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("VACCINEID");

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.Centerid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("SYS_C00307621");

                entity.HasOne(d => d.IdvaccinehistoryNavigation)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.Idvaccinehistory)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("SYS_C00307622");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("SYS_C00307615");

                entity.HasOne(d => d.Vaccine)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.Vaccineid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("SYS_C00307620");
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

                entity.Property(e => e.Image)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGE");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Testmonials)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("SYS_C00307614");
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
                    .HasMaxLength(2000)
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

                entity.Property(e => e.Vaccinename)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("VACCINENAME");

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

                entity.Property(e => e.Lat)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LAT");

                entity.Property(e => e.Lng)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LNG");

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
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("SYS_C00307624");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Vaccinehistories)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("SYS_C00307623");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
