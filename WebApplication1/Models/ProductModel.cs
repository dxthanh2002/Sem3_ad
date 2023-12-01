using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class ProductModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
       
        public string Name { get; set; }
        
        public string Images { get; set; }

        [DefaultValue(0.0f)]
        [Required]
        public float Price { get; set; }

        [DefaultValue(0.0)]
        [Required]
        public int Quantity { get; set; }
        [ForeignKey("Seasons")]

       
        public int seasonid { get; set; }
        public virtual seasonsModel Seasons { get; set; }
        
       
        [ForeignKey("Genders")]
        public int GendersId { get; set; }
        public virtual GendersModel Genders { get; set; }
        [DefaultValue(0.0)]
        [Required]
        [ForeignKey("Ages")]
        public int Ages { get; set; }
        public virtual AgesModel Age { get; set; }

        [DefaultValue(0.0f)]
        [Required]
        public float RewardPoint { get; set; }
    }
}
