using LR8_ASP_Zhyhlova.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IProductsServices, ProductsServices>();

builder.Services.AddRazorPages();

var app = builder.Build();

app.MapRazorPages();

app.UseStaticFiles();

app.UseRouting();

app.MapDefaultControllerRoute();

app.Run();
