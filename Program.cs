using AutoMapper;
using Microsoft.EntityFrameworkCore;
using projeto_estoque.Application.Profiles;
using projeto_estoque.Infrastructure.Context;
using projeto_estoque.Repositories;
using System.Reflection;
using System.Reflection.Emit;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining(typeof(Program)));
var mapperConfig = new MapperConfiguration(config =>
{
    config.AddProfile(new ProdutoProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddMvc();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

builder.Services.AddDbContext<ProdutoContext>(options =>
{
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

app.UseAuthorization();

app.MapControllers();

app.Run();
