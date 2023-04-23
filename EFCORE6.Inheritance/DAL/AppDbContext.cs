
using EFCORE6.Inheritance.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE6.Inheritance.DAL
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DbContextInitializer.Build();
            optionsBuilder.LogTo(Console.WriteLine,LogLevel.Information).UseSqlServer(DbContextInitializer.Configuration.GetConnectionString("SqlConnection"));
            

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Data anottaion olarak tanımlama yapmadan burada da tanımlama yapabiliriz
            //modelBuilder.Entity<Product>().Property(x => x.Price).HasPrecision(18, 2);
            //modelBuilder.Entity<NewProduct>().Property(x => x.Price).HasPrecision(18, 2);

            ////Her zaman has ile başlanmalı
            //// one to many 
            //modelBuilder.Entity<Category>()
            //    .HasMany(x => x.Products)
            //    .WithOne(x => x.Category).HasForeignKey(x => x.CategoryId);

            //// one to one
            //modelBuilder.Entity<Product>()
            //    .HasOne(x => x.ProductDetail)
            //    .WithOne(x => x.Product)
            //    .HasForeignKey<ProductDetail>(x => x.ProductId);

            ////one to one
            //modelBuilder.Entity<NewProduct>()
            //    .HasOne(x => x.NewProductDetail)
            //    .WithOne(x => x.NewProduct)
            //    .HasForeignKey<NewProductDetail>(x => x.Id);


            //// many to many işlemi
            //modelBuilder.Entity<Student>()
            //    .HasMany(x => x.Teachers)
            //    .WithMany(x => x.Students)
            //    .UsingEntity<Dictionary<string, object>>(
            //        "StudentTeacherAraTablo",
            //        st => st.HasOne<Teacher>()
            //        .WithMany().HasForeignKey("TeacherId").HasConstraintName("FK__TeacherId"),
            //         st => st.HasOne<Student>()
            //        .WithMany().HasForeignKey("StudentId").HasConstraintName("FK__StudentId")
            //    );


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<BasePerson> Persons { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
