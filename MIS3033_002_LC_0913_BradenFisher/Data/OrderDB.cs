using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace a
{
    public class OrderDB:DbContext
    {
        public DbSet<Order> ordersTbl {  get; set; }// a collection of orders, array of orders

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=OrderDB");
        }
        
    }
}