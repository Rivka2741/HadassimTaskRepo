using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Entity;

public partial class CoronaManagementSystemContext : DbContext
{
    public CoronaManagementSystemContext()
    {
    }

    public CoronaManagementSystemContext(DbContextOptions<CoronaManagementSystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<SickWithCoronaTbl> SickWithCoronas { get; set; } = null!;
    public virtual DbSet<UserTbl> Users { get; set; } = null!;
    public virtual DbSet<VaccinationDetailTbl> VaccinationDetails { get; set; } = null!;
    public virtual DbSet<VaccineManufacturerTbl> VaccineManufacturers { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-HGEU5KD;Initial Catalog=CoronaManagementSystem;Integrated Security=True;TrustServerCertificate=True");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SickWithCoronaTbl>(entity =>
        {
            entity.HasKey(e => e.SickId)
                .HasName("PK__SickWith__1F450E983E26633A");

            entity.ToTable("SickWithCorona");

            entity.Property(e => e.SickId).HasColumnName("SickID");

            entity.Property(e => e.PositiveResultDate).HasColumnType("date");

            entity.Property(e => e.RecoveryDate).HasColumnType("date");

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User)
                .WithMany(p => p.SickWithCoronas)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__SickWithC__UserI__3A81B327");
        });

        modelBuilder.Entity<UserTbl>(entity =>
        {

            entity.HasIndex(e => e.IdentityCard, "UQ__Users__DA5B2F6DCDC44573")
                .IsUnique();

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.Property(e => e.CellPhone).HasMaxLength(15);

            entity.Property(e => e.City).HasMaxLength(50);

            entity.Property(e => e.DateOfBirth).HasColumnType("date");

            entity.Property(e => e.FirstName).HasMaxLength(50);

            entity.Property(e => e.IdentityCard).HasMaxLength(20);

            entity.Property(e => e.LastName).HasMaxLength(50);

            entity.Property(e => e.Number).HasMaxLength(10);

            entity.Property(e => e.Phone).HasMaxLength(15);

            entity.Property(e => e.Street).HasMaxLength(50);
        });

        modelBuilder.Entity<VaccinationDetailTbl>(entity =>
        {
            entity.HasKey(e => e.VaccinationId)
                .HasName("PK__Vaccinat__466BCFA7BDBBF83E");

            entity.Property(e => e.VaccinationId).HasColumnName("VaccinationID");

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.Property(e => e.VaccineDate).HasColumnType("date");

            entity.Property(e => e.VaccineManufacturerId).HasColumnName("VaccineManufacturerID");

            entity.HasOne(d => d.User)
                .WithMany(p => p.VaccinationDetails)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Vaccinati__UserI__3F466844");

            entity.HasOne(d => d.VaccineManufacturer)
                .WithMany(p => p.VaccinationDetails)
                .HasForeignKey(d => d.VaccineManufacturerId)
                .HasConstraintName("FK__Vaccinati__Vacci__403A8C7D");
        });

        modelBuilder.Entity<VaccineManufacturerTbl>(entity =>
        {
            entity.HasKey(e => e.ManufacturerId)
                .HasName("PK__VaccineM__357E5CA1514B7D65");

            entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");

            entity.Property(e => e.ManufacturerName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

}


