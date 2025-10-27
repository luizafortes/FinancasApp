using FinancasApp.API.Middlewares;
using FinancasApp.Domain.Extensions;
using FinancasApp.Infra.Data.Extensions;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Métodos de extensão
builder.Services.AddEntityFramework(builder.Configuration);
builder.Services.AddDomainService();

var app = builder.Build();

//Middlewares
app.UseMiddleware<ExceptionMiddleware>();

// Configure the HTTP request pipeline.
app.MapOpenApi();

//Swagger
app.UseSwagger();
app.UseSwaggerUI();

//Scalar
app.MapScalarApiReference(s => s.WithTheme(ScalarTheme.BluePlanet));


app.UseAuthorization();
app.MapControllers();
app.Run();
