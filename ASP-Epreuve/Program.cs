using Shared.Repositories;
using DAL = DAL_Epreuve;
using BLL = BLL_Epreuve;
using ASP_Epreuve.Handlers;

namespace ASP_Epreuve
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Localization
            builder.Services.Configure<RequestLocalizationOptions>(options =>
            {
                string[] supportedCultures = new string[]
                {
                    "en-US",    //Si en-US, alors le pattern des input de prix sera :  pattern="^\d*\.{0,1}\d*$"
                    "fr-BE"     //Si fr-BE, alors le pattern des input de prix sera :  pattern="^\d*,{0,1}\d*$"
                };
                string defaultCulture = supportedCultures[1];   //Choisir la culture (c'est la définision du format selon la région)
                options.SetDefaultCulture(defaultCulture);      //Définir la culture par défaut
                //options.AddSupportedCultures(supportedCultures);      //Si multilingue, définir les cultures supportées par le site
                //options.AddSupportedUICultures(supportedCultures);
            });


            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddHttpContextAccessor();

            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession(options=>
            {
                options.Cookie.Name = "AspNetMVC.Session";
                options.Cookie.HttpOnly = true;
                options.IdleTimeout = TimeSpan.FromMinutes(20);
            });
            builder.Services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
                options.Secure = CookieSecurePolicy.Always;
            });

            builder.Services.AddScoped<IProduitRepository<BLL.Entities.Produit>, BLL.Services.ProduitService>();
            builder.Services.AddScoped<IProduitRepository<DAL.Entities.Produit>, DAL.Services.ProduitService>();
            builder.Services.AddScoped<ICategorieRepository<BLL.Entities.Categorie>, BLL.Services.CategorieService>();
            builder.Services.AddScoped<ICategorieRepository<DAL.Entities.Categorie>, DAL.Services.CategorieService>();
            builder.Services.AddScoped<PanierSessionManager>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseSession();
            app.UseCookiePolicy();

            app.UseStaticFiles();

            app.UseRouting();

            //Localization
            app.UseRequestLocalization();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}