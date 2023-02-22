using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Xml.Models.DbRecords;
using Xml.Options;

namespace Xml.Repositories;

public sealed class ApplicationContext : DbContext
{
    private readonly DbConnectionOptions _options;

    public ApplicationContext(IOptions<DbConnectionOptions> dbConnectionOptions)
    {
        _options = dbConnectionOptions.Value;
        // Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    public DbSet<OfferModel> Offers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer($"Server={_options.Server};" +
                                    $"Database={_options.Database};" +
                                    $"User ID={_options.UserId};" +
                                    $"Password={_options.Password};" +
                                    $"Trust Server Certificate={_options.TrustServerCertificate}");
    }
}