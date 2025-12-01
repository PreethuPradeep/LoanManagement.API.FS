using Microsoft.AspNetCore.Identity;

namespace LoanManagement.Preethu.Api.Models
{
    public class UserProfile:IdentityUser
    {
        public string FullName { get; set; }
        //nav
        public CustomerProfile Customer { get; set; }
        public OfficerProfile Officer { get; set; }
        public AdminProfile Admin { get; set; }
    }
}
