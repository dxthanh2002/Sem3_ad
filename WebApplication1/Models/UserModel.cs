using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class UserModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required]
        public string Username { get; set; }

 
        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [DefaultValue(0.0f)]
        [Required]
        public float RewardPoint { get; set; }
    }
}
