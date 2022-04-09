using ApplicationLayer.ApplicationLayerDependecyInjection;
using DataLayer.Context;
using DataLayer.DependencyInjection;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
// Add services to the container.

services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();
services.AddDbContext<WHMDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("WHMConnection")));
services.AddApplicationLayerDependecyInjection();
services.AddDataLayerDependencyInjection();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
