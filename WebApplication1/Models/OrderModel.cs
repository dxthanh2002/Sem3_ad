using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class OrderModel
    {
        [Key]
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
    }
}
