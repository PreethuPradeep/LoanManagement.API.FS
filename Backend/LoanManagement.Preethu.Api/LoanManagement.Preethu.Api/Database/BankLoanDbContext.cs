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
        public DbSet<CustomerProfile> TblCustomers { get; set; }
        public DbSet<LoanRequest> TblLoans { get; set; }
        public DbSet<LoanVerification> TblLoanVerification { get; set; }
        public DbSet<BackGroundVerification> TblBackGroundVerifications { get; set; }
        public DbSet<FeedBackQuestion> TblFeedBackQuestions { get; set; }
        public DbSet<FeedBackReply> TblFeedBackReplies { get; set; }
        public DbSet<HelpReport> TblHelpReports { get; set; }
    }
}
