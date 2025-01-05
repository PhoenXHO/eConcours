using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eConcours.Data;
using eConcours.Services;
using eConcours.Services_User;
using eConcours.Data;
using eConcours.Models;
using GestionConcoursCore.Services;
using eConcours.Services_User;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rotativa.AspNetCore;
using Wkhtmltopdf.NetCore;

namespace eConcours
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Configuration
            var configuration = builder.Configuration;

            // Ajouter les services au conteneur
            builder.Services.AddDbContext<GestionConcourCoreDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("myconn")));

            // Ajouter les services personnalisés
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

            // Ajouter les services de session
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            // Ajouter Wkhtmltopdf
            builder.Services.AddWkhtmltopdf();

            // Configurer les contrôleurs et les vues
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configurer le pipeline HTTP
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts(); // Activer HSTS
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            app.UseAuthorization();

            // Configurer Rotativa
            RotativaConfiguration.Setup(app.Environment.WebRootPath, "../wwroot/Rotativa");

            // Configurer les routes
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Landing}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
