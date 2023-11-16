using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StockControlSystem.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Stock_control_system.Services;
using StockControlSystem.Models;
using StockControlSystem.Infrastructure.Contexto.Repositories.Impl;
using StockControlSystem.Infrastructure.Contexto.Repositories;
using AutoMapper;
using StockControlSystem.DTOs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Context>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")));

builder.Services.AddScoped<SupplierRepositoryImpl>();
builder.Services.AddScoped<AddressRepositoryImpl>();
builder.Services.AddScoped<BrandRepositoryImpl>();
builder.Services.AddScoped<CategoryRepositoryImpl>();
builder.Services.AddScoped<ItemRepositoryImpl>();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.MapGet()

//app.UseHttpsRedirection();

//app.UseAuthorization();
//app.UseRouting();
//app.MapRazorPages();


app.MapControllers();

app.Run();