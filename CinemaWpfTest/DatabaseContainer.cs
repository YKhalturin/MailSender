using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace CinemaWpfTest
{
    public class DatabaseContainer : DbContext
    {
        public DatabaseContainer()
            : base("DbConnection")
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}