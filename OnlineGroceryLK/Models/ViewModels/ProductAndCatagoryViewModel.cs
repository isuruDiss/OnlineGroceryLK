using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryLK.Models.ViewModels
{
    public class ProductAndCatagoryViewModel
    {
        public IEnumerable<Category> CategoryList { get; set; }
        public Product Product { get; set; }
        public List<string> ProductList { get; set; }
        public string StatusMessage { get; set; }
    }
}
