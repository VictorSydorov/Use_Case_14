using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCultures = new[]
    {
            new CultureInfo("en"),
            new CultureInfo("fr"),
            new CultureInfo("uk")
        };

    options.DefaultRequestCulture = new RequestCulture("en");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});


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
    name: "Localized",
    pattern: "{lang}/{controller}/{action}",
    defaults: new { lang ="en",controller = "Home", action = "Index" });

app.Use(async (context, next) =>
{
    string requestedCulture = context!.Request!.Path!.Value!.Split('/')[1];
    if (string.IsNullOrEmpty(requestedCulture)) requestedCulture = "en";
    var culture = new CultureInfo(requestedCulture);
    CultureInfo.CurrentCulture = culture;
    CultureInfo.CurrentUICulture = culture;

    await next.Invoke();
});

app.Run();
