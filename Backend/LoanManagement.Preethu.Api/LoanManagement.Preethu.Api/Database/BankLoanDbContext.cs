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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //one to one

            builder.Entity<CustomerProfile>()
                .HasOne(c => c.User)
                .WithOne(u => u.Customer)
                .HasForeignKey<CustomerProfile>(c => c.UserId);

            builder.Entity<OfficerProfile>()
                .HasOne(o => o.User)
                .WithOne(u => u.Officer)
                .HasForeignKey<OfficerProfile>(o => o.UserId);

            builder.Entity<AdminProfile>()
                .HasOne(a => a.User)
                .WithOne(u => u.Admin)
                .HasForeignKey<AdminProfile>(a => a.UserId);

            //one to manyyi
            builder.Entity<OfficerProfile>()
                .HasOne(o => o.Supervisor)
                .WithMany(a => a.Officers)
                .HasForeignKey(o => o.AdminId)
                .IsRequired(false);

            //cascade fix
            builder.Entity<BackGroundVerification>()
                .HasOne(bg => bg.Officer)
                .WithMany()
                .HasForeignKey(bg => bg.OfficerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<LoanVerification>()
                .HasOne(lv => lv.Officer)
                .WithMany()
                .HasForeignKey(lv => lv.OfficerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<HelpReport>()
                .HasOne(h => h.User)
                .WithMany()
                .HasForeignKey(h => h.UserId);

            //decimal precision
            builder.Entity<LoanRequest>().Property(p => p.AmountRequested).HasPrecision(18, 2);
            builder.Entity<LoanRequest>().Property(p => p.CollateralEstimatedWorth).HasPrecision(18, 2);
            builder.Entity<LoanRequest>().Property(p => p.InterestRate).HasPrecision(5, 4);
            builder.Entity<OfficerProfile>().Property(p => p.Salary).HasPrecision(18, 2);
        }
    }
}
