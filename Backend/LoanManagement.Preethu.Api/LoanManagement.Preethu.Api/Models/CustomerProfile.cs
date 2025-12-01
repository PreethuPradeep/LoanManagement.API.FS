using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LoanManagement.Preethu.Api.Models
{
    public class CustomerProfile
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        public string UserId { get; set; }

        [JsonIgnore]
        [ForeignKey("UserId")]
        public UserProfile User { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public double AnnualIncome { get; set; }
        [Required]
        public string Occupation { get; set; }
    }
}
