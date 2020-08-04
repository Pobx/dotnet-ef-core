using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dotnet_ef_core.Models {
  public class OrderConfiguration : IEntityTypeConfiguration<Order> {
    public void Configure (EntityTypeBuilder<Order> builder) {
      builder.Property (t => t.CreatedDateTime).IsRequired ().HasDefaultValueSql ("GETUTCDATE()");
      builder.HasMany (i => i.Items).WithOne (o => o.Order).OnDelete (DeleteBehavior.SetNull);
    }
  }
}