using System.ComponentModel.DataAnnotations;

namespace LoanManagement.Preethu.Api.Models
{
    public class OfficerProfile
    {
        public int OfficerId { get; set; }
        public int UserId { get; set; }
        public UserProfile User { get; set; }
        [Display( Name = "Supervisor")]
        public string AdminId { get; set; }
        public AdminProfile Admin { get; set; }
        public double Salary { get; set; }
        public string Region { get; set; }
    }
}