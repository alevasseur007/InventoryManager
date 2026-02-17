using InventoryAPI.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace InventoryAPI.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
