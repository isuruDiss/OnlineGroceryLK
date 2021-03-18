﻿ using OnlineGroceryLK.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryLK.Models
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            Qty = 1;
        }


        [Key]
        public int Id { get; set; }

        public string ApplicationUserId { get; set; }

        [NotMapped]
        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        public int StockMasterId { get; set; }

        [NotMapped]
        [ForeignKey("StockMasterId")]
        public virtual StockMaster StockMaster { get; set; }



        [Range(1,int.MaxValue, ErrorMessage ="Please enter a value greater than or equal to {1}")]
        public int Qty { get; set; }
    }
}
