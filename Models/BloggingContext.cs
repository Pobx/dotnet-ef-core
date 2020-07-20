using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace dotnet_ef_core.Models {
  public class BloggingContext : DbContext {

    public BloggingContext (DbContextOptions<BloggingContext> options) : base (options) { }

    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }

    // protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
    //   optionsBuilder.UseSqlServer ("Server=localhost,1433;Database=pop_test_db2;User Id=sa;Password=P@ssword1234;");
    // }
  }

  public class Blog {
    public int BlogId { get; set; }
    public string Url { get; set; }
    public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    public List<Post> Posts { set; get; } = new List<Post> ();
  }

  public class Post {
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public int BlogId { get; set; }
    public Blog Blog { get; set; }
  }
}