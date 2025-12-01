using System.ComponentModel.DataAnnotations;

namespace LoanManagement.Preethu.Api.Models
{
    public class OfficerProfile
    {
        public int OfficerId { get; set; }
        public string UserId { get; set; }
        public UserProfile User { get; set; }
        public int? AdminId { get; set; }
        public AdminProfile Supervisor { get; set; }
        public double Salary { get; set; }
        public string Region { get; set; }
    }
}