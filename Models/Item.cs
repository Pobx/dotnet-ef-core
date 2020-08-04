using System;

namespace dotnet_ef_core.Models {
  public class Item : MainModel {
    public int ItemId { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }

  }
}