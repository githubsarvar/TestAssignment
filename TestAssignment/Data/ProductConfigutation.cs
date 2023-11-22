using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestAssignment.Areas.Data;
using TestAssignment.Infrastructure;

namespace TestAssignment.Data;

public class ProductConfigutation : BaseEntityConfiguration<Product>
{
    public override void Configure(EntityTypeBuilder<Product> builder)
    {
        base.Configure(builder);
        builder.Property(p => p.Name).HasMaxLength(250).IsRequired();
        builder.Property(p => p.Price).IsRequired();
        builder.Property(p => p.Quantiy).IsRequired();
    }
}
