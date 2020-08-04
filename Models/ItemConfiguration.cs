using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dotnet_ef_core.Models {
  public class ItemConfiguration : IEntityTypeConfiguration<Item> {
    public void Configure (EntityTypeBuilder<Item> builder) {
      builder.Property (i => i.Name).IsRequired ().HasMaxLength (200);
      builder.Property (i => i.CreatedDateTime).IsRequired ().HasDefaultValueSql ("GETUTCDATE()");
    }
  }
}