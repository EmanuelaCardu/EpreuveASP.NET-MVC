using Shared.Repositories;
using DAL = DAL_Epreuve;
using BLL = BLL_Epreuve;

namespace ASP_Epreuve
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IProduitRepository<BLL.Entities.Produit>, BLL.Services.ProduitService>();
            builder.Services.AddScoped<IProduitRepository<DAL.Entities.Produit>, DAL.Services.ProduitService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
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