﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineGroceryLK.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineGroceryLK.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        } 

        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<StockMaster> StockMaster { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        public IEnumerable<object> ShoppingCart { get; internal set; }

        //public object MenuItem { get; internal set; }
    }
}
