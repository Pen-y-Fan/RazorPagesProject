namespace webapp.Data;

using Microsoft.EntityFrameworkCore;

public class CustomerDbContext : DbContext
{
    public CustomerDbContext (DbContextOptions<CustomerDbContext> options)
        : base(options)
    {
    }

    public DbSet<webapp.Models.Customer> Customer => Set<webapp.Models.Customer>();
}
