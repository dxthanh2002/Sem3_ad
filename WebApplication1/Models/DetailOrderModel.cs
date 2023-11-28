using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class DetailOrderModel
    {
        [Key]
        public int DetailId { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public float Money { get; set; }
        public int Quantity { get; set; }
    }
}
