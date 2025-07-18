namespace Company.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime PostedDate { get; set; } = DateTime.UtcNow;

        public int BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }
    }
}
