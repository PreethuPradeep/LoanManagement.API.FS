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

        public Task<UserProfile?> FindByNameAsync(string username)
        {
            return userManager.FindByNameAsync(username);
        }

        public Task<IList<string>> GetRolesAsync(UserProfile user)
        {
            return userManager.GetRolesAsync(user);
        }

        public Task<IdentityResult> RegisterUserAsync(UserProfile user, string password)
        {
            return userManager.CreateAsync(user, password);
        }
    }
}
