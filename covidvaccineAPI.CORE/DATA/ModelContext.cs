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

        public virtual DbSet<Footer> Footers { get; set; }

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
