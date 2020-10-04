using aspnet_react.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnet_react.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {}
         public DbSet<Product> Products { get; set;}
        public DbSet<Category> Categories { get; set; }
    }
}