using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopStore.Model.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        [Required]
        [MaxLength(30)]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        [Required]
        public ICollection<Product> Products { get; set; }

        public Brand()
        {
            Products = new List<Product>();
        }
    }
}