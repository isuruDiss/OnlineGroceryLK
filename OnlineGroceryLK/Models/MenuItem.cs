﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryLK.Models
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }


        public string Image { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }


        public virtual Category Category { get; set; }

        //[Display(Name = "SubCategory")]
        //public int SubCategoryId { get; set; }


        //public virtual SubCategory SubCategory { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = " Price should be greater than Rs.1")]
        public decimal Price { get; set; }




    }
}