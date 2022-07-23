namespace blog_rn7s2_backend.Models
{
    public class PostOverview
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Updated { get; set; }
        public string Abstract { get; set; }
    }
}
