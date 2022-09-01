using Application.Abstract.Context;
using Application.Abstract.Repositories;
using Application.Abstract.Services;
using Application.Concrete.Managers;
using Application.Concrete.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IGenericRepository<Product>, ProductRepository> ();
builder.Services.AddScoped<IProductService, ProductManager>();


//builder.Services.AddScoped<ApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
















builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
