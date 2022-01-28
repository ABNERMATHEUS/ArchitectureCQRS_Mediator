using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesManagement.Core.Entities.Bases;

namespace MoviesManagement.Infrastructure.Mapping;

public class BaseEntityMapping : IEntityTypeConfiguration<BaseEntity<Guid>>
{
    public void Configure(EntityTypeBuilder<BaseEntity<Guid>> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Active).IsRequired();
        builder.Property(x => x.ModifiedDate);
    }
}