
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
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information).UseSqlServer(DbContextInitializer.Configuration.GetConnectionString("SqlConnection"));


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().ToSqlQuery("select Id,Name,Price,DiscountPrice from Product");

            //Fluent APı tarafında bu şekilde tanımlanır Indexlemek istediğim alanlar için hasIndex kullanılır
            //Name ile beraber farkı datların da gelmesini istersek  .IncludeProperties(x => new { x.Price, x.Stock });
            // kod bloğunu da eklememiz gerekir
            // sorgumuzu yazarken hangi alanları da çekeceğimiz belirlersek kod yapısnı ona göre yazmamız lazım

            modelBuilder.Entity<Product>().HasIndex(x => new { x.Name, x.Barcode })
                .IncludeProperties(x => new { x.Price, x.Stock });


            // kural belirtmek istersek
            modelBuilder.Entity<Product>().HasCheckConstraint("PriceDiscountCheck","[Price]>[DiscountPrice]");


            //modelBuilder.Entity<PersonManager>().OwnsOne(x => x.Person, x =>
            //{
            //    x.Property(x => x.Name).HasColumnName("Ad");
            //    x.Property(x => x.SurName).HasColumnName("Soyad");
            //    x.Property(x => x.Age).HasColumnName("Yas");
            //});

            //modelBuilder.Entity<PersonEmployee>().OwnsOne(x => x.Person, x =>
            //{
            //    x.Property(x => x.Name).HasColumnName("Ad");
            //    x.Property(x => x.SurName).HasColumnName("Soyad");
            //    x.Property(x => x.Age).HasColumnName("Yas");
            //});


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

        public DbSet<PersonManager> PersonManagers { get; set; }
        public DbSet<PersonEmployee> PersonEmployees { get; set; }
    }
}
