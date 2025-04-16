using System.ComponentModel.DataAnnotations;

namespace RedVine.Models
{
    public class Chat
    {
        [Key]
        public Guid Id { get; set; }

        public string? Owner { get; set; }
        public string? Recipiant { get; set; }
        public List<ChatMessage> Messages { get; set; } = [];

    }
}
