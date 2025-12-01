using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanManagement.Preethu.Api.Models
{
    public class CustomerProfile
    {
        [Key]
        public int CustomerId { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public UserProfile User { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public double AnnualIncome { get; set; }
        public string Occupation { get; set; }

    }
}
