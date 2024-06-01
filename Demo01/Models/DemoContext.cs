using Microsoft.EntityFrameworkCore;

namespace Demo01.Models
{
    public class DemoContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Detail> Details { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAB1504-30\\SQLEXPRESS;" +
                "Initial Catalog=DatosDB; Integrated Security=True;trustservercertificate=True");
        }
    }
}
