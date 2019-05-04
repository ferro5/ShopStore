using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopStore.Model.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [MaxLength(30)]
        [Required]
        public string Title { get; set; }
        [MaxLength(250)]
        [Required]
        public string Dwscription { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public bool InStock{ get; set; }
        public bool IsNew { get; set; }
        public bool IsBest { get; set; }
        public bool Sales { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int? BrandId { get; set; }
        public int? CategoryId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
    }
}
