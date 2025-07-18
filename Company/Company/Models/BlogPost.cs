using System.ComponentModel.DataAnnotations;

namespace Company.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }

        // For SEO
        public string Slug { get; set; }

        public ICollection<Comments> Comments { get; set; } = new List<Comments>();
    }
}
