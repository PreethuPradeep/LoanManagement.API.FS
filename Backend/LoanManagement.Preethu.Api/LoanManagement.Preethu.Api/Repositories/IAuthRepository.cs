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
        Task<UserProfile> FindByEmailAsync(string email);
        Task<string> GenerateEmailConfirmationTokenAsync(UserProfile user);
        Task<IdentityResult> ConfirmEmailAsync(UserProfile user, string token);
        Task<string> GeneratePasswordResetTokenAsync(UserProfile user);
        Task<IdentityResult> ResetPasswordAsync(UserProfile user, string token, string newPassword);
        Task<UserProfile> FindByIdAsync(string id);
        Task<IdentityResult> UpdateUserAsync(UserProfile user);
        Task<IdentityResult> DeleteUserAsync(UserProfile user);
        Task<IdentityResult> RemoveFromRoleAsync(UserProfile user, string roleName);
    }
}
