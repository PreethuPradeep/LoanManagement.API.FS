using System.ComponentModel.DataAnnotations;

namespace LoanManagement.Preethu.Api.Models
{
    public class AdminProfile
    {
        [Key]
        public int AdminId { get; set; }
        public string UserId { get; set; }
        public UserProfile User { get; set; }
        public string Region { get; set; }
        public ICollection<OfficerProfile> Officers { get; set; }
    }
}