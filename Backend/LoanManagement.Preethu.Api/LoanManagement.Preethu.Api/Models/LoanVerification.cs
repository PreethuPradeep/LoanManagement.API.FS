using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanManagement.Preethu.Api.Models
{
    public class LoanVerification
    {
        [Key]
        public int LoanVerificationId { get; set; }
        public int LoanRequestId { get; set; }
        [ForeignKey("LoanRequestId")]
        public LoanRequest Loan { get; set; }
        public int OfficerId { get; set; }
        [ForeignKey("OfficerId")]
        public OfficerProfile Officer { get; set; }
        public string VerificationNotes { get; set; }
        public VerificationResult Result { get; set; }
        public DateTime CraetedAt { get; set; } = DateTime.UtcNow;

    }
}