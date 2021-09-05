using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryLK.Models
{
    public class StockMaster
    {
        public int Id { get; set; }

        public string Description { get; set; }

        [Display(Name = "Supplier")]
        public string SupplierId { get; set; }
        [NotMapped]
        [ForeignKey("SupplierId")]
        public virtual ApplicationUser Supplier { get; set; }
        public string Image { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [Display(Name = "Product")]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = " Price should be greater than ${1}")]
        public double Price { get; set; }

        [Required]
        public int Qty { get; set; }

        //[Required]
        public string Status { get; set; }
        public enum Sstatus { NA = 0, Available = 1, Unavailable = 2 }
    }
}
