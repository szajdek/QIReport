using Microsoft.EntityFrameworkCore;
using QualityShims.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityShims
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<PartType> PartTypes { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<NominalDimension> NominalDimensions { get; set; }
        public DbSet<ActualDimension> ActualDimensions { get; set; }
        public DbSet<InspectionReport> InspectionReports { get; set; }
        public DbSet<ShimInspectionReport> ShimInspectionReports { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InspectionReport>()
                .HasOne(ir => ir.Part)
                .WithMany(p => p.InspectionReports)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
