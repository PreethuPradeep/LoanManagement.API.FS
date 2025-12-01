using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LoanManagement.Preethu.Api.Models
{
    public class OfficerProfile
    {
        [Key]
        public int OfficerId { get; set; }

        [Required]
        public string UserId { get; set; }

        [JsonIgnore]
        [ForeignKey("UserId")]
        public UserProfile User { get; set; }

        public int? AdminId { get; set; }

        [JsonIgnore]
        [ForeignKey("AdminId")]
        public AdminProfile Supervisor { get; set; }
        [Required]
        public string Region { get; set; }
    }
}
