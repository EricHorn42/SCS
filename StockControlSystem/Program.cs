using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StockControlSystem.Infrastructure;
using Microsoft.AspNetCore.Builder;
using StockControlSystem.Models;
using StockControlSystem.Infrastructure.Contexto.Repositories.Impl;
using StockControlSystem.Infrastructure.Contexto.Repositories;
using AutoMapper;
using StockControlSystem.DTOs;
using StockControlSystem.Repositories;
using StockControlSystem.Services;
using StockControlSystem.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Identity.Web.UI;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));


if (!builder.Environment.IsDevelopment())
{

    builder.Services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
        .AddMicrosoftIdentityWebApp(builder.Configuration.GetSection("AzureAd"));


    builder.Services.AddAuthorization(options =>
    {
        // By default, all incoming requests will be authorized according to the default policy.
        options.FallbackPolicy = options.DefaultPolicy;
    });
}

builder.Services.AddControllers();

builder.Services.AddDbContext<Context>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING")));

builder.Services.AddScoped<ISupplierRepository, SupplierRepositoryImpl>();
builder.Services.AddScoped<IAddressRepository, AddressRepositoryImpl>();
builder.Services.AddScoped<IBrandRepository, BrandRepositoryImpl>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepositoryImpl>();
builder.Services.AddScoped<IItemRepository, ItemRepositoryImpl>();

builder.Services.AddScoped<ISupplierService, SupplierService>();
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IBrandService, BrandService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IItemService, ItemService>();
builder.Services.AddRazorPages();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();


app.UseHttpsRedirection();
app.UseRouting();

app.MapControllers();
app.MapRazorPages();
app.Run();