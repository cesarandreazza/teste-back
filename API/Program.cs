using Aplicacao.Interfaces;
using Aplicacao.Profiles;
using Aplicacao.Servicos;
using Dominio.Interfaces.Repositorios;
using Dominio.Interfaces.Servicos;
using Dominio.Servicos;
using Microsoft.EntityFrameworkCore;
using Repositorio;
using Repositorio.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddScoped<IProdutoServicoApp, ProdutoServicoApp>();
builder.Services.AddScoped<IPedidoServicoApp, PedidoServicoApp>();

builder.Services.AddScoped<IProdutoServico, ProdutoServico>();
builder.Services.AddScoped<IPedidoServico, PedidoServico>();

builder.Services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
builder.Services.AddScoped<IPedidoRepositorio, PedidoRepositorio>();

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
