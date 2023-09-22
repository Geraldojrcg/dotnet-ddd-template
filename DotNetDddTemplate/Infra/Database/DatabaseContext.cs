using Microsoft.EntityFrameworkCore;

namespace DotNetDddTemplate.Infra.Database;

using Models;

public class DatabaseContext: DbContext
{
    private readonly IConfiguration _configuration;

    public DatabaseContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(_configuration.GetConnectionString("DatabaseConnectionString"));
    }

    public DbSet<UserModel> Users { get; set; }
}