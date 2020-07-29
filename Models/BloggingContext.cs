using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace dotnet_ef_core.Models {
  public class BloggingContext : DbContext {

    public BloggingContext (DbContextOptions<BloggingContext> options) : base (options) { }

    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Order> Orders { get; set; }
    protected override void OnModelCreating (ModelBuilder modelBuilder) {
      modelBuilder.Entity<Order> ()
        .Property (t => t.CreatedDateTime)
        .IsRequired ()
        .HasDefaultValueSql ("NOW()");
    }

  }

  public class Order {
    public int OrderId { get; set; }
    public DateTime CreatedDateTime { get; set; }
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
    public Blog Blog { get; set; }

    [ForeignKey ("Blog")]
    public int BlogFK { get; set; }
  }

  public class Author {
    public int AuthorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    [NotMapped]
    public string FullName => $"{FirstName} {LastName}";
    public ICollection<Book> Books { get; set; }
  }

  public class Book {
    public int BookId { get; set; }
    public string Title { get; set; }
    public Author Author { get; set; }

  }
}