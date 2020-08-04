using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace dotnet_ef_core.Models {
  public class AppDbContext : DbContext {

    public AppDbContext (DbContextOptions<AppDbContext> options) : base (options) { }

    protected override void OnModelCreating (ModelBuilder modelBuilder) {
      modelBuilder.ApplyConfigurationsFromAssembly (Assembly.GetExecutingAssembly ());
    }

  }

}