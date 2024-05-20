using Anyar.DataAccesLayer;
using Microsoft.EntityFrameworkCore;


namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<SperingsContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

          




            var app = builder.Build();

            app.UseStaticFiles();
            app.MapControllerRoute("Default", "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
