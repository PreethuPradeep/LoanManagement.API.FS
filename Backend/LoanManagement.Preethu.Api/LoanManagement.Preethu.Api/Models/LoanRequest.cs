using System.ComponentModel.DataAnnotations.Schema;

namespace LoanManagement.Preethu.Api.Models
{
    public class LoanRequest
    {
        public int LoanRequestId { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public CustomerProfile Customer { get; set; }
        public LoanType LoanType { get; set; }
        public decimal AmountRequested { get; set; }
        public string CollateralDetails { get; set; }
        public string Purpose { get; set; }
        public int TimePeriodInMonths { get; set; }
        public decimal InterestRate { get; set; }
        public decimal CollateralEstimatedWorth { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public LoanRequestStatus Status { get; set; }
        public ICollection<LoanVerification> LoanVerification { get; set; }
        public ICollection<BackGroundVerification> BackGroundVerification { get; set; }
    }
}
