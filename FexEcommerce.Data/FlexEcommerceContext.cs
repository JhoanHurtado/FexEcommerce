using FexEcommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FexEcommerce.Data
{
    public class FlexEcommerceContext : DbContext
    {
    
        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Source> Sources { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Tax> Taxes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<purchasesDetail> PurchasesDetails { get; set; }
        public DbSet<WishList> WishLists { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }


        public FlexEcommerceContext(DbContextOptions options) : base(options){}

    }
}
