using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class UserModel
    {
        [Key]
        [Column(TypeName = "nvarchar(30)")]
        [Required]
        public string Username { get; set; }

        [Column(TypeName = "nvarchar(512)")]
        [Required]
        public string Password { get; set; }
        [Column(TypeName = "nvarchar(128)")]
        [Required]
        public string Email { get; set; }

        [DefaultValue(0.0f)]
        [Required]
        public float RewardPoint { get; set; }
    }
}
