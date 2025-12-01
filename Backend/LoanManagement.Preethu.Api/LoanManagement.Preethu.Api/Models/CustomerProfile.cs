namespace LoanManagement.Preethu.Api.Models
{
    public class CustomerProfile
    {
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public UserProfile User { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public double AnnualIncome { get; set; }
        public string Occupation { get; set; }

    }
}
