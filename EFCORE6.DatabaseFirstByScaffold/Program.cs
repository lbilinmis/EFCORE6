// See https://aka.ms/new-console-template for more information
using EFCORE6.DatabaseFirstByScaffold.Models;
using Microsoft.EntityFrameworkCore;
using System;

Console.WriteLine("Hello, World!");


//using (var context = new AppDbContext(DbContextInitializer.OptionsBuilder.Options))
using (var context = new DatabaseFirstDBContext())
{
    var products = await context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine(p.Id + " : Product : " + p.Name + " Price : " + p.Price);
    });

}

