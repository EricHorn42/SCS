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
using StockControlSystem.Filters;
using StockControlSystem.Conventions;
using StockControlSystem.Factories;

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

builder.Services.AddRazorPages()
    .AddMicrosoftIdentityUI();


builder.Services.AddRazorPages(options =>
{
    #region snippet1
    options.Conventions.Add(new GlobalTemplatePageRouteModelConvention());
    #endregion

    options.Conventions.Add(new GlobalHeaderPageApplicationModelConvention());


    #region snippet3
    //options.Conventions.AddFolderRouteModelConvention("/OtherPages", model =>
    //{
        //var selectorCount = model.Selectors.Count;
        //for (var i = 0; i < selectorCount; i++)
        //{
        //    var selector = model.Selectors[i];
        //    model.Selectors.Add(new SelectorModel
        //    {
        //        AttributeRouteModel = new AttributeRouteModel
        //        {
        //            Order = 2,
        //            Template = AttributeRouteModel.CombineTemplates(
        //                selector.AttributeRouteModel!.Template,
        //                "{otherPagesTemplate?}"),
        //        }
        //    });
        //}
    //});
    #endregion

    #region snippet4
    options.Conventions.AddPageRouteModelConvention("/About", model =>
    {
        var selectorCount = model.Selectors.Count;
        for (var i = 0; i < selectorCount; i++)
        {
            var selector = model.Selectors[i];
            model.Selectors.Add(new SelectorModel
            {
                AttributeRouteModel = new AttributeRouteModel
                {
                    Order = 2,
                    Template = AttributeRouteModel.CombineTemplates(
                        selector.AttributeRouteModel!.Template,
                        "{aboutTemplate?}"),
                }
            });
        }
    });
    #endregion

    #region snippet5
    options.Conventions.AddPageRoute("/Contact", "TheContactPage/{text?}");
    #endregion

    #region snippet6
    options.Conventions.AddFolderApplicationModelConvention("/OtherPages", model =>
    {
        model.Filters.Add(new AddHeaderAttribute(
            "OtherPagesHeader", new string[] { "OtherPages Header Value" }));
    });
    #endregion

    #region snippet7
    options.Conventions.AddPageApplicationModelConvention("/About", model =>
    {
        model.Filters.Add(new AddHeaderAttribute(
            "AboutHeader", new string[] { "About Header Value" }));
    });
    #endregion

    #region snippet8
    options.Conventions.ConfigureFilter(model =>
    {
        if (model.RelativePath.Contains("OtherPages/Page2"))
        {
            return new AddHeaderAttribute(
                "OtherPagesPage2Header",
                new string[] { "OtherPages/Page2 Header Value" });
        }
        return new EmptyFilter();
    });
    #endregion

    #region snippet9
    options.Conventions.ConfigureFilter(new AddHeaderWithFactory());
    #endregion

    #region snippet10
    options.Conventions.Add(new GlobalPageHandlerModelConvention());
    #endregion
});

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