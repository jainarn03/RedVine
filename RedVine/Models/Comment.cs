using System.ComponentModel.DataAnnotations;

namespace RedVine.Models
{
    public class Comment
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string? Owner { get; set; }

        [Required]
        public string? CommentText { get; set; }

        [Range(0, int.MaxValue)]
        public int? Likes { get; set; }

        [Required]
        public DateTime? PostDate { get; set; }
    }
}
