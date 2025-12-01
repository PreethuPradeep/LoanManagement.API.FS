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
        public DbSet<UserProfile> TblUsers { get; set; }
        public DbSet<OfficerProfile> TblOfficers { get; set; }
        public DbSet<AdminProfile> TblAdmins { get; set; }
        public DbSet<CustomerProfile> TblCustomer { get; set; }

    }
}
