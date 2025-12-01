namespace LoanManagement.Preethu.Api.Models
{
    public class FeedBackQuestion
    {
        public int FeedBackId { get; set; }

        public string FeedBackQn { get; set; }
        public bool IsActive { get; set; }
        public ICollection<FeedBackReply> Answers { get; set; }
    }
}
