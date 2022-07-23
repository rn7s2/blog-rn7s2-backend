using blog_rn7s2_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace blog_rn7s2_backend.Data
{
    public class BlogContextSQLite : DbContext
    {
        public DbSet<Config>? Configs { get; set; }
        public DbSet<Page>? Pages { get; set; }
        public DbSet<Post>? Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Config>().ToTable(nameof(Config));
            modelBuilder.Entity<Page>().ToTable(nameof(Page));
            modelBuilder.Entity<Post>().ToTable(nameof(Post));
        }
    }
}
