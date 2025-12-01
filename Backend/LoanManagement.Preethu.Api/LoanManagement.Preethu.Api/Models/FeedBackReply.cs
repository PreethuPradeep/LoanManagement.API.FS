namespace LoanManagement.Preethu.Api.Models
{
    public class FeedBackReply
    {
        public int FeedBackReplyId { get; set; }
        public int CustomerId { get; set; }
        public CustomerProfile Customer { get; set; }
        public int FeedBackQustionId { get; set; }
        public FeedBackQuestion FeedBackQuestion { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}