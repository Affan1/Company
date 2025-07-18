using Microsoft.EntityFrameworkCore;
using Company.Models; 
namespace Company.Db
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options)
        : base(options) { }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Comments> Comments { get; set; }
    }
}
