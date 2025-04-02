using System.ComponentModel.DataAnnotations;

namespace RedVine.Models
{
    public class GroupChat
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(20)]
        public string? Name { get; set; }

        public string? Path { get; set; }

        [Range(0, 10, ErrorMessage = "Max 10 members per group chat")]
        public int? NumMembers { get; set; }

        public List<string>? Members { get; set; }

        public List<Guid>? Messages { get; set; }

    }
}
