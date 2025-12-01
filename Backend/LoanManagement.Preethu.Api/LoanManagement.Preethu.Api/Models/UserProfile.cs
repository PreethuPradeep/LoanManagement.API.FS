using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace LoanManagement.Preethu.Api.Models
{
    public class UserProfile:IdentityUser
    {
        [Required]
        public string FullName { get; set; }
        //nav
        public CustomerProfile Customer { get; set; }
        public OfficerProfile Officer { get; set; }
        public AdminProfile Admin { get; set; }
    }
}
