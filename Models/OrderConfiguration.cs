using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dotnet_ef_core.Models {
  public class OrderConfiguration : IEntityTypeConfiguration<Order> {
    public void Configure (EntityTypeBuilder<Order> builder) {
      builder.Property (t => t.CreatedDateTime)
        .IsRequired ()
        .HasDefaultValueSql ("GETUTCDATE()");

      // builder.Property (t => t.Label).IsRequired ().HasDefaultValue ("Pobx");
      // builder.HasOne (s => s.Saler).WithMany (o => o.Orders);s
    }
  }
}