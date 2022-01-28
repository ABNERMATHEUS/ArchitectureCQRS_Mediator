using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesManagement.Core.Entities;

namespace MoviesManagement.Infrastructure.Mapping;

public class MoviesMapping : IEntityTypeConfiguration<Movies>
{
    public void Configure(EntityTypeBuilder<Movies> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
    }
}