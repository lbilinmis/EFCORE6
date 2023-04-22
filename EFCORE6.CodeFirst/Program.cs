// See https://aka.ms/new-console-template for more information
using EFCORE6.CodeFirst.DAL;
using EFCORE6.CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");


//using (var context = new AppDbContext(DbContextInitializer.OptionsBuilder.Options))
using (var context = new AppDbContext())
{
    //// db ye veri ekleme işlemi hazırlığında state durumu detached durumda olur 
    //// ekleme işlemi gerçekleştikten sonra state durumu added durumda olur
    //var product = new Product() { Name="Yeni Ürün 1",Barcode="Barcode Yeni 1",Price=100,Stock=110 };

    //Console.WriteLine(" Ekleme yapmadan state durumu : "+context.Entry(product).State);
    //context.Entry(product).State = EntityState.Added;
    ////await context.Products.AddAsync(product);
    //Console.WriteLine(" Ekleme yapıldıktan sonra state durumu : " + context.Entry(product).State);
    //await context.SaveChangesAsync();
    //Console.WriteLine(" Save change yapıldıktan sonra state durumu : " + context.Entry(product).State);


    //var products = await context.Products.ToListAsync();
    var productsAsNoTracking = await context.Products.AsNoTracking().ToListAsync();

    productsAsNoTracking.ForEach(p =>
    {
        // db den veri çekildiğinde ilk state durumu Unchange olur
        var state = context.Entry(p).State;
        Console.WriteLine(p.Id + " : Product : " + p.Name + " Price : " + p.Price + " State " + state);
    });


    // aşağıdaki kod bloğu memory projede track edilen datalar üzerinde işlem yapıyor
    context.ChangeTracker.Entries().ToList().ForEach(x =>
    {
        if (x.Entity is Product p)
        {
            //p.Price += 100;
            Console.WriteLine(p.Id + " : Product : " + p.Name + " Price : " + p.Price );

        }
    });

    context.SaveChangesAsync();

    // asnotracking sql server tarafında gelen datanın EFCORE tarafındna track edilmemesini sağlar
    // memory de tutulmaz ram i daha düzgün kullanır
}