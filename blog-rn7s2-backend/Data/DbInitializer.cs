using blog_rn7s2_backend.Models;

namespace blog_rn7s2_backend.Data
{
    public class DbInitializer
    {
        public static void Initialize(BlogContextSQLite context)
        {
            context.Database.EnsureCreated();
            if (context.Configs == null || context.Pages == null || context.Posts == null)
                throw new ArgumentException("DbContext error!");
            if (context.Configs.Any())
                return;

            context.Configs.Add(new Config { Title = "博客标题" });
            context.SaveChanges();

            var pages = new Page[]
            {
                new Page { Name = "helloworld", Author = "System", Updated = DateTime.Now, Title = "你好，世界！", Content = "***Hello, world!***", Published = true },
                new Page { Name = "about", Author = "System", Updated = DateTime.Now, Title = "关于", Content = "***About***", Published = true }
            };
            foreach (var page in pages)
                context.Pages.Add(page);
            context.SaveChanges();

            var posts = new Post[]
            {
                new Post { Title = "Post 1", Author = "System", Updated = DateTime.Now, Abstract = "Abstract 1", Content = "Content 1", Published = true },
                new Post { Title = "Post 2", Author = "System", Updated = DateTime.Now, Abstract = "Abstract 2", Content = "Content 2", Published = true }
            };
            foreach (var post in posts)
                context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}
