using System.ComponentModel.DataAnnotations.Schema;

namespace LoanManagement.Preethu.Api.Models
{
    public class BackGroundVerification
    {
        public int BackGroundVerificationId { get; set; }
        public int LoanRequestId { get; set; }
        [ForeignKey("LoanRequestId")]
        public LoanRequest Loan { get; set; }
        public int OfficerId { get; set; }
        public OfficerProfile Officer { get; set; }
        public string AddressCheck { get; set; }
        public string IncomeCheck { get; set; }
        public string OccupationCheck { get; set; }
        public string Result { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}