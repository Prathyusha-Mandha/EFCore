using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DB_first_Practice.Models;

public partial class CodeFirstContext : DbContext
{
    public CodeFirstContext()
    {
    }

    public CodeFirstContext(DbContextOptions<CodeFirstContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=Prathyusha;database=CodeFirst;integrated security=True;trustservercertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StuId);

            entity.Property(e => e.English).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Hindi).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Maths).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Science).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Social).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Telugu).HasColumnType("decimal(18, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
