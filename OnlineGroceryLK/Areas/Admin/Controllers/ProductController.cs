using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineGroceryLK.Data;
using OnlineGroceryLK.Models;
using OnlineGroceryLK.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryLK.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;

        [TempData]
        public string StatusMessage { get; set; }

        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }

        public ProductController()
        {
        }

        //Get INDEX
        public async Task<IActionResult> Index()
        {
            var products = await _db.Product.Include(s => s.Category).ToListAsync();
            return View(products);
        }
        //GET - CREATE
        public async Task<IActionResult> Create()
        {
            ProductAndCatagoryViewModel model = new ProductAndCatagoryViewModel()
            {
                CategoryList = await _db.Category.ToListAsync(),
                Product = new Models.Product(),
                ProductList = await _db.Product.OrderBy(p => p.Name).Select(p => p.Name).Distinct().ToListAsync()
            };

            return View(model);
        }

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductAndCatagoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var doesSubCategoryExists = _db.Product.Include(s => s.Category).Where(s => s.Name == model.Product.Name && s.Category.Id == model.Product.CategoryId);

                if (doesSubCategoryExists.Count() > 0)
                {
                    //Error
                    StatusMessage = "Error : Product exists under " + doesSubCategoryExists.First().Category.Name + " Category. Please use another name.";
                }
                else
                {
                    _db.Product.Add(model.Product);
             
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            ProductAndCatagoryViewModel modelVM = new ProductAndCatagoryViewModel()
            {
                CategoryList = await _db.Category.ToListAsync(),
                Product = model.Product,
                ProductList = await _db.Product.OrderBy(p => p.Name).Select(p => p.Name).ToListAsync(),
                StatusMessage = StatusMessage
            };
            return View(modelVM);
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



        //GET - EDIT
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Product = await _db.Product.SingleOrDefaultAsync(m => m.Id == id);

            if (Product == null)
            {
                return NotFound();
            }

            ProductAndCatagoryViewModel model = new ProductAndCatagoryViewModel()
            {
                CategoryList = await _db.Category.ToListAsync(),
                Product = Product,
                ProductList = await _db.Product.OrderBy(p => p.Name).Select(p => p.Name).Distinct().ToListAsync()
            };

            return View(model);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductAndCatagoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var doesSubCategoryExists = _db.Product.Include(s => s.Category).Where(s => s.Name == model.Product.Name && s.Category.Id == model.Product.CategoryId);

                if (doesSubCategoryExists.Count() > 0)
                {
                    //Error
                    StatusMessage = "Error : Product exists under " + doesSubCategoryExists.First().Category.Name + " category. Please use another name.";
                }
                else
                {
                    var subCatFromDb = await _db.Product.FindAsync(model.Product.Id);
                    subCatFromDb.Name = model.Product.Name;
                    subCatFromDb.Brand = model.Product.Brand;
                    subCatFromDb.CategoryId = model.Product.CategoryId;

                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            ProductAndCatagoryViewModel modelVM = new ProductAndCatagoryViewModel()
            {
                CategoryList = await _db.Category.ToListAsync(),
                Product = model.Product,
                ProductList = await _db.Product.OrderBy(p => p.Name).Select(p => p.Name).ToListAsync(),
                StatusMessage = StatusMessage
            };
            //modelVM.SubCategory.Id = id;
            return View(modelVM);
        }


        //GET Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var subCategory = await _db.Product.Include(s => s.Category).SingleOrDefaultAsync(m => m.Id == id);
            if (subCategory == null)
            {
                return NotFound();
            }

            return View(subCategory);
        }

        //GET Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await _db.Product.Include(s => s.Category).SingleOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        //POST Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _db.Product.SingleOrDefaultAsync(m => m.Id == id);
            _db.Product.Remove(product);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

    }
}
