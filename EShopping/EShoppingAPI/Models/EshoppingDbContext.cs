using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EShoppingAPI.Models;

public partial class EshoppingDbContext : DbContext
{
    public EshoppingDbContext()
    {
    }

    public EshoppingDbContext(DbContextOptions<EshoppingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblLogin> TblLogins { get; set; }

    public virtual DbSet<TblOrder> TblOrders { get; set; }

    public virtual DbSet<TblOrderDetail> TblOrderDetails { get; set; }

    public virtual DbSet<TblPayment> TblPayments { get; set; }

    public virtual DbSet<TblProduct> TblProducts { get; set; }

    public virtual DbSet<TblRole> TblRoles { get; set; }

    public virtual DbSet<TblUserDetail> TblUserDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-HVUT504;Initial Catalog=EShoppingDB;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblLogin>(entity =>
        {
            entity.ToTable("tblLogin");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(1000);
        });

        modelBuilder.Entity<TblOrder>(entity =>
        {
            entity.ToTable("tblOrder");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrderNumber).HasMaxLength(50);
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblOrderDetail>(entity =>
        {
            entity.ToTable("tblOrderDetails");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblPayment>(entity =>
        {
            entity.ToTable("tblPayment");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(1000)
                .HasColumnName("TransactionID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblProduct>(entity =>
        {
            entity.ToTable("tblProduct");

            entity.Property(e => e.Color).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductDescription).HasMaxLength(2000);
            entity.Property(e => e.ProductName).HasMaxLength(1000);
            entity.Property(e => e.Size).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblRole>(entity =>
        {
            entity.ToTable("tblRole");

            entity.Property(e => e.RoleName).HasMaxLength(50);
        });

        modelBuilder.Entity<TblUserDetail>(entity =>
        {
            entity.ToTable("tblUserDetail");

            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
