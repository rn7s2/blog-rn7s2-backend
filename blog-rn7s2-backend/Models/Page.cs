namespace blog_rn7s2_backend.Models
{
    public class Page
    {
        // “导航属性”，需要阅读更多文档来确认
        public int PageId { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public DateTime Updated { get; set; } = DateTime.MinValue;
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
}
