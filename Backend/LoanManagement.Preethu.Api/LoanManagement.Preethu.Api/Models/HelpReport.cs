using System.ComponentModel.DataAnnotations;

namespace LoanManagement.Preethu.Api.Models
{
    public class HelpReport
    {
        [Key]
        public int ReportId { get; set; }
        public string UserId { get; set; }
        public UserProfile User { get; set; }
        public string Subject { get; set; }
        public string MessageBody { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
