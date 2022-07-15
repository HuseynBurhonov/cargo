using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Data;

public class DataContext : DbContext
{
    protected DataContext() { }

    public DataContext(DbContextOptions options) : base(options) { }
}