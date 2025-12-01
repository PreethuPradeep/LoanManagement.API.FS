namespace LoanManagement.Preethu.Api.Models.DTOs
{
    public class ChangePasswordDto
    {
        public string UserId { get; set; }
        public string oldPassword { get; set; }
        public string newPassword { get; set; }
    }
}
