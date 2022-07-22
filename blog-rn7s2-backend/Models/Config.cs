namespace blog_rn7s2_backend.Models
{
    public class PageConfig
    {
        public string Title { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }

    public class Config
    {
        public string Title { get; set; } = string.Empty;
        public List<PageConfig> Pages { get; set; } = new();
    }
}
