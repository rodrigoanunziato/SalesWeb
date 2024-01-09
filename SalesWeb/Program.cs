using Microsoft.EntityFrameworkCore;
using SalesWeb.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string mySqlConnection =
                builder.Configuration.GetConnectionString("SalesWebContext");
builder.Services.AddDbContext<SalesWebContext>(options =>
    options.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection), builder => builder.MigrationsAssembly("SalesWeb")).EnableSensitiveDataLogging());

builder.Services.AddScoped<SeedingService>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.Services.CreateScope().ServiceProvider.GetRequiredService<SeedingService>().Seed();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts. 
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
