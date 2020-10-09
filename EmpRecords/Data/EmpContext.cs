using EmpRecords.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpRecords.Data
{
    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions<EmpContext> options) : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Standard> Standards { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Contract>().ToTable("Contract");
            modelBuilder.Entity<Standard>().ToTable("Standard");
        }
    }
}