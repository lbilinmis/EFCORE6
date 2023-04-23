// See https://aka.ms/new-console-template for more information
using EFCORE6.CodeFirst_Relations.DAL;
using EFCORE6.CodeFirst_Relationships.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

//using (var context = new AppDbContext(DbContextInitializer.OptionsBuilder.Options))
using (var context = new AppDbContext())
{
    Category category=new Category() { Name="Bilgisayar"};
    Product product = new Product() { Name = "Apple", Price = 84000, Stock = 10, Barcode = "Apple i9 15,6", Category = category };
    ProductDetail detail = new ProductDetail() { Color = "Gray", Height = 1920, Weightth = 2, Width = 1080, Product = product };

    await context.ProductDetails.AddAsync(detail);
    await context.SaveChangesAsync();
    var products = await context.Products.ToListAsync();


    var student1=new Student() { Name="A Can BİLİNMİŞ",Age=15};
    var student2=new Student() { Name="Levent BİLİNMİŞ",Age=38};
    var teacher=new Teacher() { Name="Mehmet BİLİNMİŞ",Students = new List<Student>() { student1, student2 } };

    await context.Teachers.AddAsync(teacher);
    await context.SaveChangesAsync();

    products.ForEach(p =>
    {
        Console.WriteLine(p.Name);
    });

}