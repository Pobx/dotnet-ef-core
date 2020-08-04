using System;

namespace dotnet_ef_core.Models {
  public class Item : MainModel {
    public int ItemId { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; }

  }
}