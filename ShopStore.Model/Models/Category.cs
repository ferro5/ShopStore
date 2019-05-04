using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopStore.Model.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(30)]
        public string Title { get; set; }
        public ICollection<Product>Products { get; set; }

        public Category()
        {
            Products = new List<Product>();
        }
    }
}