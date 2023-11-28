﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class DetailOrderModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetailId { get; set; }

        [Required]
        public int ProductId { get; set; }
        [Required]
        public int OrderId { get; set; }

        [DefaultValue(0.0f)]
        [Required]
        public float Money { get; set; }

        [DefaultValue(0.0)]
        [Required]
        public int Quantity { get; set; }
    }
}
