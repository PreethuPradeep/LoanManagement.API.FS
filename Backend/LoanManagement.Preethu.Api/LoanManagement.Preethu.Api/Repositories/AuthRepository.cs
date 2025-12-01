using LoanManagement.Preethu.Api.Models;
using Microsoft.AspNetCore.Identity;

namespace LoanManagement.Preethu.Api.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly UserManager<UserProfile> userManager;
        public AuthRepository(UserManager<UserProfile> userManager)
        {
            this.userManager = userManager;
        }
        public Task<IdentityResult> AddToRoleAsync(UserProfile user, string roleName)
        {
            return userManager.AddToRoleAsync(user, roleName);        }

        public Task<IdentityResult> ChangePasswordAsync(UserProfile user, string oldPassword, string newPassword)
        {
            return userManager.ChangePasswordAsync(user, oldPassword, newPassword);
        }

        public Task<bool> CheckPasswordAsync(UserProfile user, string password)
        {
            return userManager.CheckPasswordAsync(user, password);
        }

        public Task<IdentityResult> ConfirmEmailAsync(UserProfile user, string token)
        {
            return userManager.ConfirmEmailAsync(user, token);
        }

        public Task<IdentityResult> DeleteUserAsync(UserProfile user)
        {
            return userManager.DeleteAsync(user);
        }

        public Task<UserProfile> FindByEmailAsync(string email)
        {
            return userManager.FindByEmailAsync(email);
        }

        public Task<UserProfile> FindByIdAsync(string id)
        {
            return userManager.FindByIdAsync(id);
        }

        public Task<UserProfile?> FindByNameAsync(string username)
        {
            return userManager.FindByNameAsync(username);
        }

        public Task<string> GenerateEmailConfirmationTokenAsync(UserProfile user)
        {
            return userManager.GenerateEmailConfirmationTokenAsync(user);
        }

        public Task<string> GeneratePasswordResetTokenAsync(UserProfile user)
        {
            return userManager.GeneratePasswordResetTokenAsync(user);
        }

        public Task<IList<string>> GetRolesAsync(UserProfile user)
        {
            return userManager.GetRolesAsync(user);
        }

        public Task<IdentityResult> RegisterUserAsync(UserProfile user, string password)
        {
            return userManager.CreateAsync(user, password);
        }

        public Task<IdentityResult> RemoveFromRoleAsync(UserProfile user, string roleName)
        {
            return userManager.RemoveFromRoleAsync(user, roleName);
        }

        public Task<IdentityResult> ResetPasswordAsync(UserProfile user, string token, string newPassword)
        {
            return userManager.ResetPasswordAsync(user, token, newPassword);
        }

        public Task<IdentityResult> UpdateUserAsync(UserProfile user)
        {
            return userManager.UpdateAsync(user);
        }
    }
}
