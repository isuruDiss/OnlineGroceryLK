using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryLK.Models.ViewModels
{
    public class IndexViewModel
    {
      //  public IEnumerable<MenuItem> MenuItem { get; set; }
        public IEnumerable<Category> Category { get; set; }
        public IEnumerable<Product> Product { get; set; }

        public IEnumerable<StockMaster> StockMaster { get; set; }


    }
}
