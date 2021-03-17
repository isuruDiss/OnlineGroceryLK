using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryLK.Areas.Supplier.Controllers
{
    [Area("Supplier")]
    public class StockController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
