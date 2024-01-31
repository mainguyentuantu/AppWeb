using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AppWeb.Data;

public partial class ProductsContext : DbContext
{
    public ProductsContext()
    {
    }

    public ProductsContext(DbContextOptions<ProductsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-00I7L7J\\TU;Database=Products;User ID=sa;Password=12345;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
