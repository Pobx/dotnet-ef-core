using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_ef_core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnet_ef_core.Controllers {
  [Route ("api/[controller]")]
  [ApiController]
  public class ValuesController : ControllerBase {
    private readonly BloggingContext _bloggingContext;
    public ValuesController (BloggingContext bloggingContext) {
      _bloggingContext = bloggingContext;
    }
    // GET api/values
    [HttpGet]
    public async Task<ActionResult> Get () {
      var blogs = await _bloggingContext.Blogs.ToListAsync ();
      return Ok (blogs);
    }

    [HttpGet]
    [Route ("Create")]
    public async Task<ActionResult> Create () {

      var blog = new Blog {
        Url = "www.example5555.com",
        Posts = new List<Post> {
        new Post { Title = "Test Post 1", Content = "Content Post 1" },
        new Post { Title = "Test Post 2", Content = "Content Post 2" },
        new Post { Title = "Test Post 3", Content = "Content Post 3" },
        }
      };

      await _bloggingContext.AddAsync<Blog> (blog);
      var affectedRows = await _bloggingContext.SaveChangesAsync ();

      return Created ("", affectedRows);
    }

    [HttpGet]
    [Route ("Create2")]
    public async Task<ActionResult> Create2 () {

      var blog = new Blog {
        Url = "www.example2.com",
      };

      var post1 = new Post { Title = "Test Post 1", Content = "Content Post 1", Blog = blog };
      var post2 = new Post { Title = "Test Post 2", Content = "Content Post 2", Blog = blog };
      var post3 = new Post { Title = "Test Post 3", Content = "Content Post 3", Blog = blog };

      await _bloggingContext.AddAsync<Blog> (blog);
      var affectedRows = await _bloggingContext.SaveChangesAsync ();

      return Created ("", affectedRows);
    }

    [HttpGet]
    [Route ("Create3")]
    public async Task<ActionResult> Create3 () {

      var blog = new Blog {
        Url = "www.example3.com",
      };

      var posts = new List<Post> {
        new Post { Title = "Test Post 1", Content = "Content Post 1", Blog = blog },
        new Post { Title = "Test Post 2", Content = "Content Post 2", Blog = blog },
        new Post { Title = "Test Post 3", Content = "Content Post 3", Blog = blog }
      };

      await _bloggingContext.AddRangeAsync (posts);
      var affectedRows = await _bloggingContext.SaveChangesAsync ();

      return Created ("", affectedRows);
    }

    [HttpGet]
    [Route ("Update")]
    public async Task<ActionResult> Update () {

      var blog = await _bloggingContext.Blogs.FirstAsync (a => a.BlogId == 1);
      blog.Url = "www.pop.com";
      _bloggingContext.Entry (blog).State = EntityState.Modified;

      var affectedRows = await _bloggingContext.SaveChangesAsync ();
      return Ok (blog);

    }

    [HttpGet]
    [Route ("Update2")]
    public async Task<ActionResult> Update2 () {

      var blog = new Blog {
        BlogId = 1,
        Url = "www.pop3sss.com",
      };

      var posts = new List<Post> {
        new Post { PostId = 1, Title = "Test Post 1 TrackGraph", Content = "Content Post 1 TrackGraph 1", Blog = blog },
        new Post { PostId = 2, Title = "Test Post 2 TrackGraph", Content = "Content Post 2 TrackGraph 2", Blog = blog },
        new Post { PostId = 3, Title = "Test Post 3 TrackGraph", Content = "Content Post 3 TrackGraph 3", Blog = blog }
      };

      blog.Posts.AddRange (posts);

      // _bloggingContext.ChangeTracker.TrackGraph (blog, e => {
      //   e.Entry.State = EntityState.Unchanged;

      //   if ((e.Entry.Entity as Post) != null) {
      //     _bloggingContext.Entry (e.Entry.Entity as Post).Property ("Content").IsModified = true;
      //   }
      // });

      _bloggingContext.Entry (blog).State = EntityState.Modified;

      var affectedRows = await _bloggingContext.SaveChangesAsync ();
      return Ok (affectedRows);

    }

  }
}