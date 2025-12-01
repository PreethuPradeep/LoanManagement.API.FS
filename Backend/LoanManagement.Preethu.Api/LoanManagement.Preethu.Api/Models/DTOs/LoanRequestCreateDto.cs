namespace LoanManagement.Preethu.Api.Models.DTOs
{
    public class LoanRequestCreateDto
    {
        public int CustomerId { get; set; }
        public string LoanType { get; set; }
        public decimal AmountRequested { get; set; }
        public string Purpose { get; set; }
        public string CollateralDetails { get; set; }
        public decimal CollateralEstimatedWorth { get; set; }
        public int TimePeriodInMonths { get; set; }
    }
}
