using System.ComponentModel.DataAnnotations;

namespace RedVine.Models
{
    public class Report
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string? Text { get; set; }

        [Required]
        public string? Sender { get; set; }

        [Required]
        public ReportReason? Reason { get; set; }

        [Required]
        public DateTime? Created { get; set; }
    }
}
