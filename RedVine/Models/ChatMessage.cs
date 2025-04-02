using System.ComponentModel.DataAnnotations;

namespace RedVine.Models
{
    public class ChatMessage
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string? Owner { get; set; }

        [Required]
        public string? Message { get; set; }

        public string? Reciever { get; set; }

        [Required]
        public DateTime? Created { get; set; }
    }
}
