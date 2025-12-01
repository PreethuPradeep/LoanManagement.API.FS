using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LoanManagement.Preethu.Api.Models
{
    public class FeedBackReply
    {
        [Key]
        public int FeedBackReplyId { get; set; }
        public int CustomerId { get; set; }
        [JsonIgnore]
        [ForeignKey("CustomerId")]
        public CustomerProfile Customer { get; set; }
        public int FeedBackQustionId { get; set; }
        [JsonIgnore]
        [ForeignKey("FeedBackQuestionId")]
        public FeedBackQuestion FeedBackQuestion { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}