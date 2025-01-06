using GestionConcoursCore.Data;
using GestionConcoursCore.Services;
using GestionConcoursCore.Services_User;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rotativa.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Ajouter des services au conteneur DI
builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.CheckConsentNeeded = context => false;
    options.MinimumSameSitePolicy = SameSiteMode.None;
});

builder.Services.AddMvc();
builder.Services.AddDbContext<GestionConcourCoreDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("myconn")));

builder.Services.AddTransient<ISearch3Service, Search3ServiceImp>();
builder.Services.AddTransient<ICorbeil3Service, Corbeil3ServiceImp>();
builder.Services.AddTransient<ISelectionService, SelectionServiceImp>();
builder.Services.AddTransient<IPreselectionService, PreselectionServiceImp>();
builder.Services.AddTransient<ICandidatService, CandidatServiceImp>();
builder.Services.AddTransient<GestionConcoursCore.Services.IEpreuveService, GestionConcoursCore.Services.EpreuveServiceImp>();
builder.Services.AddTransient<GestionConcoursCore.Services_User.IEpreuveService, GestionConcoursCore.Services_User.EpreuveServiceImp>();
builder.Services.AddScoped<IEnregistrementService, EnregistrementServiceImp>();
builder.Services.AddScoped<ICorrectionService, CorrectionServiceImp>();
builder.Services.AddTransient<IStatistiqueService, StatistiqueServiceImpl>();
builder.Services.AddTransient<IFiche, FicheImp>();
builder.Services.AddTransient<IIndexService, IndexServiceImp>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddSession();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configurez le pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseCookiePolicy();
app.UseSession();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Landing}/{action=Index}/{id?}");

// Configuration de Rotativa
RotativaConfiguration.Setup((Microsoft.AspNetCore.Hosting.IHostingEnvironment)app.Services.GetService(typeof(IWebHostEnvironment)));

app.Run();
