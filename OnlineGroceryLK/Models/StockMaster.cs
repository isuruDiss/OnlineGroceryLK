using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryLK.Models
{
    public class StockMaster
    {

        public string Stock_Code { get; set; }
        public string Brand { get; set; }
        public string Stk_Stock_Status { get; set; }
        public string Created_By { get; set; }
        public DateTime Created_date { get; set; }
        public string Stk_Description { get; set; }
    }
}
