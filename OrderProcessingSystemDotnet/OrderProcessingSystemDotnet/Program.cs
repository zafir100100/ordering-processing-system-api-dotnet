﻿using Microsoft.EntityFrameworkCore;
using OrderProcessingSystemDotnet.Models;
using OrderProcessingSystemDotnet.Controllers;
using OrderProcessingSystemDotnet.Interfaces;
using OrderProcessingSystemDotnet.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<OpsApiDbContext>(options => options.UseInMemoryDatabase("OpsDb"));
builder.Services.AddTransient<ICustomerService, CustomerRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
