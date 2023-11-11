using Microsoft.EntityFrameworkCore;

namespace Laboratorio11.Models
{
    public class DemoContext: DbContext
    {

        public DemoContext(DbContextOptions<DemoContext> options)
            :base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<Detail> Detail { get; set; }
        public DbSet<Product> Product { get; set; }

    }
}
