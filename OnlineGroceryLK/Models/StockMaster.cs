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

        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Supplier")]
        public int SupplierId { get; set; }

        //[ForeignKey("SupplierId")]
        //public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [Required]
        [Display(Name = "Product")]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        public string Stock_Code { get; set; }
        [Required]
        public int Qty { get; set; }
        public string Stk_Stock_Status { get; set; }
        public string Created_By { get; set; }
        public DateTime Created_date { get; set; }

    }
}
