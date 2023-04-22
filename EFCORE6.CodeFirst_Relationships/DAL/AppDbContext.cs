
using EFCORE6.CodeFirst_Relationships.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE6.CodeFirst_Relations.DAL
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DbContextInitializer.Build();
            optionsBuilder.UseSqlServer(DbContextInitializer.Configuration.GetConnectionString("SqlConnection"));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Her zaman has ile başlanmalı
            modelBuilder.Entity<Category>()
                .HasMany(x => x.Products)
                .WithOne(x => x.Category).HasForeignKey(x => x.CategoryId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
    }
}
