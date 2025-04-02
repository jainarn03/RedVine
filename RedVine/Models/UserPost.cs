using System.ComponentModel.DataAnnotations;

namespace RedVine.Models
{
    public class UserPost
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public UploadType Type { get; set; }

        [StringLength(500, ErrorMessage = "500 or less characters")]
        public string? Description { get; set; }

        [Range(0, int.MaxValue)]
        public int? Likes { get; set; }

        [Required]
        public string? Path { get; set; }

        public List<Comment>? Comments { get; set; } = [];
        public List<Tags>? Tags { get; set; } = [];

        [Required]
        public string? Owner { get; set; }

        [Required]
        public DateTime? UploadDate { get; set; }
    }
}
