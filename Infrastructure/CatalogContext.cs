using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection;
using ApplicationCore.Entities;
using ApplicationCore.Entities.BasketAggregate;
using ApplicationCore.Entities.OrderAggregate;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class CatalogContext : DbContext
{
#pragma warning disable CS8618 // Required by Entity Framework
    public CatalogContext(DbContextOptions<CatalogContext> options) : base(options) { }

    public DbSet<Basket> Baskets { get; set; }
    public DbSet<CatalogItem> CatalogItems { get; set; }
    public DbSet<CatalogBrand> CatalogBrands { get; set; }
    public DbSet<CatalogType> CatalogTypes { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<BasketItem> BasketItems { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
