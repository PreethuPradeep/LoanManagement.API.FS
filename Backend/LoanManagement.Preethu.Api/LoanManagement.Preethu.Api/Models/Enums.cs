namespace LoanManagement.Preethu.Api.Models
{
    public enum LoanType
    {
        Car,
        Gold,
        Home,
        Education,
        Personal,
        Business,Others

    }
    public enum LoanRequestStatus
    {
        Pending,
        Processing,
        AwaitingVerification,
        Approved,
        Rejected,
        Withdrawn
    }
    public enum VerificationResult
    {
        Pending,
        Satisfactory,
        Unsatisfactory
    }
}
