using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;

using WebTest.Models;
using WebTest.Data;
    


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<WebTestContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebTestContext") ?? throw new InvalidOperationException("Connection string 'WebTestContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

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
    pattern: "{controller=Models}/{action=Index}/{id?}");

app.Run();
