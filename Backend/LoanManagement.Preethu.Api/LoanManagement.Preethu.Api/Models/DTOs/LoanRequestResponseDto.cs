namespace LoanManagement.Preethu.Api.Models.DTOs
{
    public class LoanRequestResponseDto
    {
        public int LoanRequestId { get; set; }
        public int CustomerId { get; set; }
        public string LoanType { get; set; }
        public decimal AmountRequested { get; set; }
        public string Purpose { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
