using LoanManagement.Preethu.Api.Models;
using Microsoft.AspNetCore.Identity;

namespace LoanManagement.Preethu.Api.Repositories
{
    public interface IAuthRepository
    {
        Task<IdentityResult> RegisterUserAsync(UserProfile user, string password);
        Task<UserProfile?> FindByNameAsync(string username);
        Task<bool> CheckPasswordAsync(UserProfile user, string password);
        Task<IdentityResult> AddToRoleAsync(UserProfile user, string roleName);
        Task<IList<string>> GetRolesAsync(UserProfile user);
        Task<IdentityResult> ChangePasswordAsync(UserProfile user, string oldPassword, string newPassword);
    }
}
