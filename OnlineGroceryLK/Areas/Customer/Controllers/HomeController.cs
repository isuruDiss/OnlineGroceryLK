﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineGroceryLK.Data;
using OnlineGroceryLK.Models;
using OnlineGroceryLK.Models.ViewModels;
using OnlineGroceryLK.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OnlineGroceryLK.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }


        public async Task<IActionResult> Index()
        {
            IndexViewModel IndexVM = new IndexViewModel()
            {
                StockMaster = await _db.StockMaster.Include(m => m.Category).Include(m => m.Product).ToListAsync(),
                Category = await _db.Category.ToListAsync(),

            };

            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            if (claim != null)
            {
                var cnt = _db.ShoppingCart.Where(u => u.ApplicationUserId == claim.Value).ToList().Count;
                HttpContext.Session.SetInt32(SD.ssShoppingCartCount, cnt);
            }



            return View(IndexVM);
        }

        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            //var menuItemFromDb = await _db.StockMaster.Include(m => m.Category).Where(m => m.Id == id).FirstOrDefaultAsync();
            var menuItemFromDb = await _db.StockMaster.Include(m => m.Category).Include(m => m.Product).Where(m => m.Id == id).FirstOrDefaultAsync();

            ShoppingCart cartObj = new ShoppingCart()
            {
                StockMaster = menuItemFromDb,
                StockMasterId = menuItemFromDb.Id,
                ProductName = menuItemFromDb.Product.Name,
                //ProductId = menuItemFromDb.ProductId


            };

            return View(cartObj);
        }



        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(ShoppingCart CartObject)
        {
            CartObject.Id = 0;
            if (ModelState.IsValid)
            {
                var claimsIdentity = (ClaimsIdentity)this.User.Identity;
                var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                CartObject.ApplicationUserId = claim.Value;

                ShoppingCart cartFromDb = await _db.ShoppingCart.Where(c => c.ApplicationUserId == CartObject.ApplicationUserId
                                                && c.StockMasterId == CartObject.StockMasterId).FirstOrDefaultAsync();



                var menuItemFromDb = await _db.StockMaster.Include(m => m.Category).Include(m => m.Product).Where(m => m.Id == CartObject.StockMasterId).FirstOrDefaultAsync();
                CartObject.ProductName = menuItemFromDb.Product.Name.ToString(); ;

                if (cartFromDb == null)
                {
                    await _db.ShoppingCart.AddAsync(CartObject);
                }
                else
                {
                    cartFromDb.Qty = cartFromDb.Qty + CartObject.Qty;
                }
                //    cartFromDb.ProductName = cartFromDb.StockMaster.Product.Name.ToString();
                await _db.SaveChangesAsync();

                var count = _db.ShoppingCart.Where(c => c.ApplicationUserId == CartObject.ApplicationUserId).ToList().Count();
                HttpContext.Session.SetInt32(SD.ssShoppingCartCount, count);

                return RedirectToAction("Index");
            }
            else
            {

                var menuItemFromDb = await _db.StockMaster.Include(m => m.Category).Include(m => m.Product).Where(m => m.Id == CartObject.StockMasterId).FirstOrDefaultAsync();

                ShoppingCart cartObj = new ShoppingCart()
                {
                    StockMaster = menuItemFromDb,
                    StockMasterId = menuItemFromDb.Id
                };

                return View(cartObj);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
