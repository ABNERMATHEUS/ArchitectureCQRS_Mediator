using Microsoft.EntityFrameworkCore;
using MoviesManagement.Core.Entities;
using MoviesManagement.Infrastructure.Mapping;

namespace MoviesManagement.Infrastructure.Context;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new BaseEntityMapping());
        modelBuilder.ApplyConfiguration(new MoviesMapping());
    }
}