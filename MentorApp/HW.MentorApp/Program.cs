using HW.MentorApp.DATA;
using Microsoft.EntityFrameworkCore;

namespace HW.MentorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<MentorAppContext>(options =>
            {
                options.UseSqlServer("Server=DESKTOP-Q4CUAVA\\SQLEXPRESS;Database=MentorAppDb;Trusted_Connection=True;TrustServerCertificate=True;");
            });

            var app = builder.Build();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
