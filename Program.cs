using eConcours.Data;
using eConcours.Services;
using eConcours.Services_User;
using GestionConcoursCore.Services;
using Microsoft.EntityFrameworkCore;

namespace eConcours
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container
            builder.Services.AddControllersWithViews();

            // Access the configuration object
            var configuration = builder.Configuration;

            // Configure the DbContext with the connection string
            builder.Services.AddDbContext<GestionConcourCoreDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("myconn")));


            builder.Services.AddTransient<ISearch3Service, Search3ServiceImp>();
            builder.Services.AddTransient<ISelectionService, SelectionServiceImp>();
            builder.Services.AddTransient<IPreselectionService, PreselectionServiceImp>();
            builder.Services.AddTransient<ICandidatService, CandidatServiceImp>();
            builder.Services.AddTransient<Services.IEpreuveService, Services.EpreuveServiceImp>();
            builder.Services.AddTransient<Services_User.IEpreuveService, Services_User.EpreuveServiceImp>();
            builder.Services.AddScoped<IEnregistrementService, EnregistrementServiceImp>();
            builder.Services.AddScoped<ICorrectionService, CorrectionServiceImp>();
            builder.Services.AddTransient<IStatistiqueService, StatistiqueServiceImpl>();
            builder.Services.AddTransient<IFiche, FicheImp>();
            builder.Services.AddTransient<IIndexService, IndexServiceImp>();
            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            // Configure cookies
            builder.Services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true; // Ask for user consent for cookies
                options.MinimumSameSitePolicy = SameSiteMode.None; // Allow cross-site cookies
            });

            // Add session services
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30); // Session timeout
                options.Cookie.HttpOnly = true; // Protect against client-side script access
                options.Cookie.IsEssential = true; // Necessary for the app to function
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            // Use cookie policy
            app.UseCookiePolicy();

            // Use session
            app.UseSession();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Landing}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
