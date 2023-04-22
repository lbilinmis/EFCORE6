// See https://aka.ms/new-console-template for more information
using EFCORE6.CodeFirst_Relations.DAL;
using EFCORE6.CodeFirst_Relationships.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

//using (var context = new AppDbContext(DbContextInitializer.OptionsBuilder.Options))
using (var context = new AppDbContext())
{
    Category category=new Category() { Name="Bilgisayar"};
    Product product = new Product() { Name = "Lenovo", Price = 14000, Stock = 10, Barcode = "Lenovo i7 15,6", Category = category };
    ProductDetail detail = new ProductDetail() { Color = "Gray", Height = 100, Weightth = 100, Width = 100, Product = product };

    await context.ProductDetails.AddAsync(detail);
    await context.SaveChangesAsync();
    var products = await context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine(p.Name);
    });

}