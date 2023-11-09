using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StockControlSystem.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Context>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")));
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.MapGet()

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

app.Run();