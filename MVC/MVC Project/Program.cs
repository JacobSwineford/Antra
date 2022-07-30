using Core.Contracts.Repository;
using Core.Contracts.Service;
using Infrastructure.Data;
using Infrastructure.Repository;
using Infrastructure.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IRegionRepositoryAsync, RegionRepositoryAsync>();
builder.Services.AddScoped<IRegionServiceAsync, RegionServiceAsync>();

builder.Services.AddScoped<ICastRepositoryAsync, CastRepositoryAsync>();
builder.Services.AddScoped<ICastServiceAsync, CastServiceAsync>();

builder.Services.AddScoped<IMovieRepositoryAsync, MovieRepositoryAsync>();
builder.Services.AddScoped<IMovieServiceAsync, MovieServiceAsync>();

// build database connection 
builder.Services.AddSqlServer<MVCDbContext>(builder.Configuration.GetConnectionString("MVC"));

var app = builder.Build();

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
