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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
