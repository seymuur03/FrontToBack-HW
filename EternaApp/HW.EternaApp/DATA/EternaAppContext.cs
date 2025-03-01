using HW.EternaApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HW.EternaApp.DATA
{
    public class EternaAppContext:DbContext
    {
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientsImage> ClientsImages { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectImage> ProjectImages { get; set; }
        public EternaAppContext(DbContextOptions options) : base(options)
        {

        }
    }
}
