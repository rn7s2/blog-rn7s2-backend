namespace blog_rn7s2_backend.Models
{
    public class Post
    {
        public int ID { get; set; } = 0;
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public DateTime Updated { get; set; } = DateTime.MinValue;
        public string Abstract { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public bool Published { get; set; } = false;
    }
}
