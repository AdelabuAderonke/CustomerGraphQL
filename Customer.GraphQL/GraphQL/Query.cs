using Customer.GraphQL.Data;
using Customer.GraphQL.Model;

namespace Customer.GraphQL.GraphQL
{
    public class Query
    {
        public IQueryable<Client> GetClients([Service] AppDbContext context)
        {
            return context.Clients;
        }
    }
}
