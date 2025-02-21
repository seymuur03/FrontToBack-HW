using HW.MentorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HW.MentorApp.DATA
{
    public class MentorAppContext : DbContext
    {
        public DbSet<Service> Services { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<PricingService> PricingServices { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<WhyUs> WhyUs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public MentorAppContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PricingService>().HasKey(ps => new { ps.PricingId, ps.ServiceId });
            base.OnModelCreating(modelBuilder);
        }
    }
}
