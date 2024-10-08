using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;

namespace Repositorio;

public class AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : DbContext(dbContextOptions)
{
    public DbSet<Produto> Produtos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Produto>()
            .Property(p => p.Valor)
            .HasColumnType("decimal(10,2)");
        modelBuilder.Entity<Produto>()
            .Property(p => p.Nome)
            .HasColumnType("varchar(20)");
        modelBuilder.Entity<Produto>().HasData(
            new Produto { Id = 1, Nome = "Notebook", Valor = 1500 },
            new Produto { Id = 2, Nome = "Mouse", Valor = 50 },
            new Produto { Id = 3, Nome = "Teclado", Valor = 100 },
            new Produto { Id = 4, Nome = "Monitor", Valor = 200 },
            new Produto { Id = 5, Nome = "Headset", Valor = 80 },
            new Produto { Id = 6, Nome = "SSD", Valor = 100 },
            new Produto { Id = 7, Nome = "RAM", Valor = 50 },
            new Produto { Id = 8, Nome = "Processador", Valor = 200 },
            new Produto { Id = 9, Nome = "Placa Mãe", Valor = 120 },
            new Produto { Id = 10, Nome = "Fonte de Alimentação", Valor = 70 });

        modelBuilder.Entity<Pedido>()
           .Property(p => p.NomeCliente)
           .HasColumnType("varchar(60)");
        modelBuilder.Entity<Pedido>()
           .Property(p => p.EmailCliente)
           .HasColumnType("varchar(60)");

        modelBuilder.Entity<ItensPedido>()
            .HasOne(ip => ip.Pedido)
            .WithMany(p => p.ItensPedidos)
            .HasForeignKey(ip => ip.IdPedido);

        modelBuilder.Entity<ItensPedido>()
            .HasOne(ip => ip.Produto)
            .WithMany(p => p.ItensPedidos)
            .HasForeignKey(ip => ip.IdProduto);
    }
}
