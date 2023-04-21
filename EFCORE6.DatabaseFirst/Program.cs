// See https://aka.ms/new-console-template for more information

using EFCORE6.DatabaseFirst.Dal.Contexts;
using EFCORE6.DatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

using (var context = new AppDbContext(DbContextInitializer.OptionsBuilder.Options))
{
    var products = await context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine(p.Id + " : Product : " + p.Name + " Price : " + p.Price);
    });

}

