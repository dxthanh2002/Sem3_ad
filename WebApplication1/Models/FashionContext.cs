﻿using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class FashionContext : DbContext
    {
        public FashionContext(DbContextOptions<FashionContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserModel>().ToTable("Users");
            modelBuilder.Entity<ProductModel>().ToTable("Products");
            modelBuilder.Entity<DetailOrderModel>().ToTable("DetailOrder");
            modelBuilder.Entity<OrderModel>().ToTable("Order");


        }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<DetailOrderModel> DetailOrders { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<WebApplication1.Models.seasonsModel> seasonsModel { get; set; } = default!;
    }
}
