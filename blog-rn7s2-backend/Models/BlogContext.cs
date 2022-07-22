using Microsoft.EntityFrameworkCore;

namespace blog_rn7s2_backend.Models
{
    public class BlogContext : DbContext
    {
        public DbSet<Config>? Configs { get; set; }
        public DbSet<Page>? Pages { get; set; }
        public DbSet<Post>? Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source=blog.db");
    }
}
