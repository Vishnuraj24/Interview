using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EntityFramework6
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=AppDbContext")
        {
        }

        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<author> authors { get; set; }
        public virtual DbSet<book> books { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(e => e.StudentName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentGender)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.FatherName)
                .IsUnicode(false);
        }
    }
}
