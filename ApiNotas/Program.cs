using System.Reflection;
using ApiNotas.Extension;
using AspNetCoreRateLimit;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());
builder.Services.ConfigureRateLimiting();
builder.Services.AddAplicationServices();
builder.Services.ConfigureCors();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApiNotasContext>(options =>
{
    string connectionString = builder.Configuration.GetConnectionString("MysqlConex");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseIpRateLimiting();

app.UseAuthorization();

app.MapControllers();

app.Run();