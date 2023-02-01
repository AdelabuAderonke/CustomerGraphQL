using Microsoft.EntityFrameworkCore;
using Customer.GraphQL.Model;

namespace Customer.GraphQL.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Client> Clients{ get; set; }
    }
}
