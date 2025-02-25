using HW.EternaApp.DATA;
using Microsoft.EntityFrameworkCore;

namespace HW.EternaApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<EternaAppContext>(options =>
            {
                options.UseSqlServer("Server=DESKTOP-Q4CUAVA\\SQLEXPRESS;Database=EternaAppDb;Trusted_Connection=True;TrustServerCertificate=True;");
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            //if (!app.Environment.IsDevelopment())
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //}
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
