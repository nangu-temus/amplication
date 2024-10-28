using Microsoft.EntityFrameworkCore;
using OrderService.Infrastructure.Models;

namespace OrderService.Infrastructure;

public class OrderServiceDbContext : DbContext
{
    public OrderServiceDbContext(DbContextOptions<OrderServiceDbContext> options)
        : base(options) { }

    public DbSet<PurchaseOrderDbModel> PurchaseOrders { get; set; }
}
