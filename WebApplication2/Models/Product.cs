using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength:40)]
        public string Name { get; set; }
        
        [Range(minimum:0, maximum:100)]
        public int Qty { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public decimal Price { get; set; }

    }
}