namespace blog_rn7s2_backend.Models
{
    public class Page
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime Updated { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Published { get; set; }
    }
}
