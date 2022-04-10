using JopSelectData.Models;
using Microsoft.EntityFrameworkCore;

namespace JopSelectData;

public class JopSelectDatabaseContext: DbContext
{
    public JopSelectDatabaseContext(DbContextOptions<JopSelectDatabaseContext> options) : base(options)
    { }

    public DbSet<Branche> Branches { get; set; } = null!;
    public DbSet<Company>  Companies{ get; set; } = null!;
}