using System;
using System.Collections.Generic;

namespace dotnet_ef_core.Models {
  public class Order : MainModel {
    public int OrderId { get; set; }
    public ICollection<Item> Items { get; set; }
  }
}