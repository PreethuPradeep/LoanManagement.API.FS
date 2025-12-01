using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LoanManagement.Preethu.Api.Models
{
    public class LoanVerification
    {
        [Key]
        public int LoanVerificationId { get; set; }
        public int LoanRequestId { get; set; }
        [ForeignKey("LoanRequestId")]
        [JsonIgnore]
        public LoanRequest Loan { get; set; }
        public int OfficerId { get; set; }
        [ForeignKey("OfficerId")]
        [JsonIgnore]
        public OfficerProfile Officer { get; set; }
        public string VerificationNotes { get; set; }
        public VerificationResult Result { get; set; }
        public DateTime CraetedAt { get; set; } = DateTime.UtcNow;

    }
}