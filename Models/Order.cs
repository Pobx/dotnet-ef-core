using System;

namespace dotnet_ef_core.Models {
  public class Order {
    public int OrderId { get; set; }
    public string Label { get; set; }

    public DateTime CreatedDateTime { get; set; }
  }
}