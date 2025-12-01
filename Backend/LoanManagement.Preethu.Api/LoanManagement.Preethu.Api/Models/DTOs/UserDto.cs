using Microsoft.AspNetCore.Identity;

namespace LoanManagement.Preethu.Api.Models.DTOs
{
    public class UserDto
    {
        public string UserId { get; set; }
        public string FullName { get; set; }
        public IList<string> RoleName { get; set; }
        public string Email { get; set; }
    }
}
