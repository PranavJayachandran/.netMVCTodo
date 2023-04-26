using Microsoft.EntityFrameworkCore;
namespace Todo.Models.Domain;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> opts) : base(opts)
    {

    }

    public DbSet<Person> Peson { get; set; }
}