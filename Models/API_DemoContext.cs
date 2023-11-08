using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DBFirstAPI.Models
{
    public partial class API_DemoContext : DbContext
    {
        public API_DemoContext()
        {
        }

        public API_DemoContext(DbContextOptions<API_DemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Person> People{ get; set; } = null!;
        public virtual DbSet<Register> Registers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
               // optionsBuilder.UseSqlServer("Server=PF3XJLFJ230817\\SQLEXPRESS;Database=API_Demo;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<Register>(entity =>
            {
                entity.ToTable("Register");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
