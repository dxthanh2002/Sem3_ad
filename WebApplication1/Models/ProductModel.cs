using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class ProductModel
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Images { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string Seasons { get; set; }
        public string Genders { get; set; }
        public int Ages { get; set; }
        public float RewardPoint { get; set; }
    }
}
