// See https://aka.ms/new-console-template for more information
using EFCORE6.CodeFirst_Relations.DAL;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

//using (var context = new AppDbContext(DbContextInitializer.OptionsBuilder.Options))
using (var context = new AppDbContext())
{

    var products = await context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine(p.Name);
    });

}