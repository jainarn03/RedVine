using System.ComponentModel.DataAnnotations;

namespace RedVine.Models
{
    public class Tags
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Range(0, int.MaxValue)]
        public int NumPosts { get; set; }
    }
}
