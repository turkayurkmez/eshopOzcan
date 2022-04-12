using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eshop.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ürün adı boş olamaz")]
        public string Name { get; set; }
        public double Price { get; set; }
        public double? Discount { get; set; }
        public int? Stock { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }


    }
}
