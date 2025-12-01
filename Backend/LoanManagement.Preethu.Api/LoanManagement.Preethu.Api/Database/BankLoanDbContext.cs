using LoanManagement.Preethu.Api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LoanManagement.Preethu.Api.Database
{
    public class BankLoanDbContext : IdentityDbContext<UserProfile, IdentityRole, string>
    {
        public BankLoanDbContext(DbContextOptions<BankLoanDbContext> options) : base(options)
        {
            
        }
    }
}
