using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LoanManagement.Preethu.Api.Models
{
    public class AdminProfile
    {
        [Key]
        public int AdminId { get; set; }

        [Required]
        public string UserId { get; set; }

        [JsonIgnore]
        [ForeignKey("UserId")]
        public UserProfile User { get; set; }
        [Required]
        public string Region { get; set; }

        [JsonIgnore]
        public ICollection<OfficerProfile> Officers { get; set; }
    }
}
