namespace LoanManagement.Preethu.Api.Models
{
    public class HelpReport
    {
        public int ReportId { get; set; }
        public int UserId { get; set; }
        public UserProfile User { get; set; }
        public string Subject { get; set; }
        public string MessageBody { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
