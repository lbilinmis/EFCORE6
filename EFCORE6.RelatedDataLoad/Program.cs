// See https://aka.ms/new-console-template for more information
using EFCORE6.RelatedDataLoad.DAL;
using EFCORE6.RelatedDataLoad.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");


using (var context = new AppDbContext())
{

    #region Hazırlık Kısmı

    //Category category = new Category() { Name = "Bilgisayar" };
    //Product product1 = new Product() { Name = "Apple", Price = 84000, Stock = 10, Barcode = "D16 15,6", Category = category };
    //Product product2 = new Product() { Name = "Huawei", Price = 84000, Stock = 10, Barcode = "D16 15,6", Category = category };
    //Product product3 = new Product() { Name = "Lenovo", Price = 84000, Stock = 10, Barcode = "D16 15,6", Category = category };
    //ProductDetail detail1 = new ProductDetail() { Color = "Blue", Height = 1920, Weightth = 2, Width = 1080, Product = product1 };
    //ProductDetail detail2 = new ProductDetail() { Color = "Blue", Height = 1920, Weightth = 2, Width = 1080, Product = product2 };
    //ProductDetail detail3 = new ProductDetail() { Color = "Blue", Height = 1920, Weightth = 2, Width = 1080, Product = product3 };

    //await context.ProductDetails.AddRangeAsync(detail1,detail2,detail3);
    //await context.SaveChangesAsync();
    //var products = await context.Products.ToListAsync();


    //products.ForEach(p =>
    //{
    //    Console.WriteLine(p.Name);
    //});

    #endregion

    #region EagerLoading
    //Eager loading ilk anda datayı alma işlemi
    // Category tablosunu çekerken ona bağlı ürünleri de çekmek istersek
    //Include komutunu birden fazla tablo varsa thenInclude diyerek categoriye bağlı verileri getirmiş oluruz

    //var categoryVithProducts = context.Categories.Include(x => x.Products).ThenInclude(x => x.ProductDetail).First();

    //var productDetail = context.ProductDetails.Include(x => x.Product).ThenInclude(x => x.Category).First();

    //var product = context.Products.Include(x => x.ProductDetail).Include(x => x.Category).First();

    // product tablosunda iki tane arka arkaya navigate proprty olduğundan ötürü theninclude demeden işlem yapılır

    #endregion


    #region ExplicitLoading

    
    //var category = context.Categories.First(); // burada sadece kategoriler çekildi ancak altaki kod bloğunda ürünler çekilmektedir


    //// aşağıdaki işlemle beraber artık ürünler kategoriye bağlanmış olacaktır
    //context.Entry(category).Collection(x => x.Products).Load();
    //category.Products.ForEach(x =>
    //{
    //    Console.WriteLine(x.Name + " - " + x.Price);
    //});


    ////birebir ilişkilerde 
    //var product = context.Products.First();

    //context.Entry(product).Reference(x => x.ProductDetail).Load();



    #endregion

    Console.WriteLine("Tamamlandı");
}