using Microsoft.EntityFrameworkCore;

namespace EMedicine.Models
{
    public class EMedicineDbContext:DbContext
    {

        public EMedicineDbContext(DbContextOptions<EMedicineDbContext> options) : base(options) { }

        public EMedicineDbContext() { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<OrderItems>().HasKey(table => new {
                table.OrderId,
                table.MedicineId
            });
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Medicines> Medicines { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }

    }
}
