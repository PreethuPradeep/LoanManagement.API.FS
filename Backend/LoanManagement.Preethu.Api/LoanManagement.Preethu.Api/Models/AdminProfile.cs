namespace LoanManagement.Preethu.Api.Models
{
    public class AdminProfile
    {
        public int AdminId { get; set; }
        public string UserId { get; set; }
        public UserProfile User { get; set; }
        public string Region { get; set; }
        public ICollection<OfficerProfile> Officers { get; set; }
    }
}