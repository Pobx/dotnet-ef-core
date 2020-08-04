using Microsoft.EntityFrameworkCore;

namespace dotnet_ef_core.Models {
  public static class ModelBuilderExtensions {
    public static void Seed (this ModelBuilder modelBuilder) {
      modelBuilder.Entity<Order> ().HasData (
        new Order {
          OrderId = 1,
        }
      );

      modelBuilder.Entity<Item> ().HasData (
        new Item { ItemId = 1, OrderId = 1, Name = "Item 01" },
        new Item { ItemId = 2, OrderId = 1, Name = "Item 02" },
        new Item { ItemId = 3, OrderId = 1, Name = "Item 03" }
      );
    }
  }
}