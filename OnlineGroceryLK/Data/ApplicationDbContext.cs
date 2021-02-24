using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
