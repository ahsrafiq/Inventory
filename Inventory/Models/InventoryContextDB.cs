using Microsoft.EntityFrameworkCore;

namespace Inventory.Models
{
    public class InventoryContextDB : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }

        public InventoryContextDB(DbContextOptions<InventoryContextDB> options) : base(options) { }
    }
}
