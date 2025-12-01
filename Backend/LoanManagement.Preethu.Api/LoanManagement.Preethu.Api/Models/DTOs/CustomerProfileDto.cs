namespace LoanManagement.Preethu.Api.Models.DTOs
{
    public class CustomerProfileDto
    {
        public int CustomerId { get; set; }
        public string UserId { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public double AnnualIncome { get; set; }
        public string Occupation { get; set; }
    }
}
