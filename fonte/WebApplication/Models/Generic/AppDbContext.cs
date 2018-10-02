using Microsoft.EntityFrameworkCore;
using WebApplication.model.People;

namespace WebApplication.model.Generic
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){ }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            //if (!optionsbuilder.IsConfigured)
            //    optionsbuilder.UseMySQL("connectionmysql");
        }
        
        public virtual DbSet<Person> Person { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Contact> Contact { get; set; }
    }
}