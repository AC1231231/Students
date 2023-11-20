using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Students.Models;

public partial class StudentsDbContext : DbContext
{
    public StudentsDbContext()
    {
    }

    public StudentsDbContext(DbContextOptions<StudentsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentGrade> StudentGrades { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Server = LAB2-13\\SQLEXPRESS; Database=StudentsDB; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.Property(e => e.Name).IsFixedLength();
        });

        modelBuilder.Entity<StudentGrade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_StuedntGrade");

            entity.Property(e => e.StudentId).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
