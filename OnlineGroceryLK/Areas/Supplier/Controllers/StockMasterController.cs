using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineGroceryLK.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using OnlineGroceryLK.Models;
using OnlineGroceryLK.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineGroceryLK.Utility;

namespace OnlineGroceryLK.Areas.Supplier.Controllers
{
    [Area("Supplier")]
    public class StockMasterController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _hostingEnvironment;

        [BindProperty]
        public StockViewModel StockItemsVM { get; set; }

        public StockMasterController(ApplicationDbContext db, IWebHostEnvironment hostingEnvironment)
        {
            _db = db;
            _hostingEnvironment = hostingEnvironment;
            StockItemsVM = new StockViewModel()
            {
                Category = _db.Category,
                StockMaster = new Models.StockMaster()
            };



        }


        [ActionName("GetProduct")]
        public async Task<IActionResult> GetProduct(int id)
        {
            List<Product> products = new List<Product>();

            products = await (from Product in _db.Product
                              where Product.CategoryId == id
                              select Product).ToListAsync();
            return Json(new SelectList(products, "Id", "Name"));
        }
        public async Task<IActionResult> Index()
        {
            var StockItems = await _db.StockMaster.Include(m => m.Category).Include(m => m.Product).ToListAsync();
            return View(StockItems);
        }


        //GET - CREATE
        public IActionResult Create()
        {
            return View(StockItemsVM);
        }

        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePOST()
         {
            StockItemsVM.StockMaster.ProductId = Convert.ToInt32(Request.Form["ProductId"].ToString());

            if (!ModelState.IsValid)
            {
                return View(StockItemsVM);
            }

            _db.StockMaster.Add(StockItemsVM.StockMaster);
            await _db.SaveChangesAsync();

            //Work on the image saving section

            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;

            var menuItemFromDb = await _db.StockMaster.FindAsync(StockItemsVM.StockMaster.Id);

            if (files.Count > 0)
            {
                //files has been uploaded
                var uploads = Path.Combine(webRootPath, "images/ItemImg");
                var extension = Path.GetExtension(files[0].FileName);

                using (var filesStream = new FileStream(Path.Combine(uploads, StockItemsVM.StockMaster.Id + extension), FileMode.Create))
                {
                    files[0].CopyTo(filesStream);
                }
                menuItemFromDb.Image = @"\images\ItemImg\" + StockItemsVM.StockMaster.Id + extension;
            }
            else
            {
                //no file was uploaded, so use default
                var uploads = Path.Combine(webRootPath, @"images\ItemImg\" + SD.DefaultFoodImage);
                System.IO.File.Copy(uploads, webRootPath + @"\images\ItemImg\" + StockItemsVM.StockMaster.Id + ".png");
                menuItemFromDb.Image = @"\images\ItemImg\" + StockItemsVM.StockMaster.Id + ".png";
            }

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }



        //GET - EDIT
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StockItemsVM.StockMaster = await _db.StockMaster.Include(m => m.Category).Include(m => m.Product).SingleOrDefaultAsync(m => m.Id == id);
            StockItemsVM.Product = await _db.Product.Where(s => s.CategoryId == StockItemsVM.StockMaster.CategoryId).ToListAsync();

            if (StockItemsVM.StockMaster == null)
            {
                return NotFound();
            }
            return View(StockItemsVM);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPOST(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            StockItemsVM.StockMaster.ProductId = Convert.ToInt32(Request.Form["SubCategoryId"].ToString());

            if (!ModelState.IsValid)
            {
                StockItemsVM.Product = await _db.Product.Where(s => s.CategoryId == StockItemsVM.StockMaster.CategoryId).ToListAsync();
                return View(StockItemsVM);
            }

            //Work on the image saving section

            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;

            var menuItemFromDb = await _db.StockMaster.FindAsync(StockItemsVM.StockMaster.Id);

            if (files.Count > 0)
            {
                //New Image has been uploaded
                var uploads = Path.Combine(webRootPath, "images/ItemImg");
                var extension_new = Path.GetExtension(files[0].FileName);

                //Delete the original file
                var imagePath = Path.Combine(webRootPath, menuItemFromDb.Image.TrimStart('\\'));

                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }

                //we will upload the new file
                using (var filesStream = new FileStream(Path.Combine(uploads, StockItemsVM.StockMaster.Id + extension_new), FileMode.Create))
                {
                    files[0].CopyTo(filesStream);
                }
                menuItemFromDb.Image = @"\images\ItemImg\" + StockItemsVM.StockMaster.Id + extension_new;
            }

            menuItemFromDb.Qty = StockItemsVM.StockMaster.Qty;
            menuItemFromDb.Price = StockItemsVM.StockMaster.Price;
            menuItemFromDb.Status = StockItemsVM.StockMaster.Status;
            menuItemFromDb.CategoryId = StockItemsVM.StockMaster.CategoryId;
            menuItemFromDb.ProductId = StockItemsVM.StockMaster.ProductId;

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }



    }
}
