using Application.Constans;
using Application.Functions;
using Application.Services;
using Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using WebDbContext;
using WebDbContext.Repository;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddDbContext<AppDbContext>(
options =>
{
    options.UseMySql(config.GetConnectionString(nameof(AppDbContext)), new MySqlServerVersion(new Version(9, 0, 0)));
});

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped<IPlayerService, PlayerService>();
builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();

builder.Services.AddSingleton<ModulesConst>();
builder.Services.AddScoped<JwtCreator>();
builder.Services.AddScoped<HashPassword>();

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
