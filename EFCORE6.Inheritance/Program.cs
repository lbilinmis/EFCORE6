// See https://aka.ms/new-console-template for more information
using EFCORE6.Inheritance.DAL;
using EFCORE6.Inheritance.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");


using (var context = new AppDbContext())
{
    //context.Persons.Add(new Manager() { Age = 1 ,Grade=1,Name="Kurumsal",SurName= "Yönetici" });
    //context.Persons.Add(new Employee() { Age = 1 ,Salary=100,Name="Kurumsal",SurName= "Personel" });

    //context.SaveChanges();

    // Category category = new Category() { Name = "Bilgisayar" };
    //Product product1 = new Product() { Name = "Apple", Price = 84000, Stock = 10, Barcode = "Profes 15,6", Category = category };
    //Product product2 = new Product() { Name = "Huawei", Price = 24000, Stock = 15, Barcode = "D16 15,6", Category = category };
    //Product product3 = new Product() { Name = "Lenovo", Price = 18000, Stock = 25, Barcode = "Z510 15,6", Category = category };
    //ProductDetail detail1 = new ProductDetail() { Color = "Cyan", Height = 1920, Weightth = 2, Width = 1080, Product = product1 };
    //ProductDetail detail2 = new ProductDetail() { Color = "Blue", Height = 1920, Weightth = 2, Width = 1080, Product = product2 };
    //ProductDetail detail3 = new ProductDetail() { Color = "Black", Height = 1920, Weightth = 2, Width = 1080, Product = product3 };

    //await context.ProductDetails.AddRangeAsync(detail1, detail2, detail3);
    //await context.SaveChangesAsync();
    //var products = await context.Products.ToListAsync();


    //products.ForEach(p =>
    //{
    //    Console.WriteLine(p.Name);
    //});

    #region 1.Yöntem
    //var query = context.Categories.Join(context.Products, x => x.Id, y => y.CategoryId, (c, p) => new
    //{

    //    CategoryName = c.Name,
    //    ProductName = p.Name,
    //    ProductPrice = p.Price
    //}).ToList();


    //foreach (var item in query)
    //{
    //    Console.WriteLine("Kategorisi :" + item.CategoryName + " Ürün Adı :" + item.ProductName + " Fiyatı : " + item.ProductPrice);
    //}


    //var query = (from x in context.Categories
    //             join y in context.Products on x.Id equals y.CategoryId
    //             select new
    //             {
    //                 CategoriesModel = x,
    //                 ProductsModel = y
    //             }).ToList();

    //var list = query.ToList();

    #endregion



    #region 2.Yöntem


    //var result = context.Categories
    //        .Join(context.Products, c => c.Id, p => p.CategoryId, (c, p) => new { c, p })
    //        .Join(context.ProductDetails, x => x.p.Id, pd => pd.ProductId, (c, pd) => new
    //        {
    //            CategoryName = c.c.Name,
    //            ProductName = c.p.Name,
    //            ProductDetailColor = pd.Color

    //        }).ToList();



    //var query = (from x in context.Categories
    //             join y in context.Products on x.Id equals y.CategoryId
    //             join d in context.ProductDetails on y.Id equals d.ProductId
    //             select new
    //             {
    //                 CategoriesModel = x,
    //                 ProductsModel = y,
    //                 ProductsDetailModel = d,
    //             }).ToList();

    //var list = query.ToList();



    //foreach (var item in list)
    //{
    //    Console.WriteLine("Kategorisi :" + item.CategoriesModel.Name + " Ürün Adı :" + item.ProductsModel.Name + " Fiyatı : " + item.ProductsModel.Price + " REnk : " + item.ProductsDetailModel.Color);
    //}

    #endregion


    ////left join işlemleri
    //var result = (from x in context.Products
    //              join pd in context.ProductDetails on x.Id equals pd.ProductId into dataProductDetailList
    //              from xProductDetail in dataProductDetailList.DefaultIfEmpty()

    //              select new
    //              {
    //                  MainData = x,
    //                  ProductDEtailData = xProductDetail
    //              }).ToList();
    //Console.WriteLine("");
    ////join xProduct in context.Products on x.Id equals xProduct.CategoryId
    ///

    //int pageSize=3, page = 1;


    //var products = await context.Products.FromSqlRaw("select * from products").ToListAsync();
    //var productsSql = await context.Products.FromSqlInterpolated($"select * from products where price>{100}").ToListAsync();


    ////Sayfalama İşlemleri
    //var newProducs = context.Products.ToList();
    //var newProducsPageView = context.Products.OrderByDescending(x=>x.Id).Skip((page-1)*pageSize).Take(3).ToList();

    ////1 2 3 4 5 6 7 8 9 10

    ////Take(2) -- Skip(0) denilirse 0. dan itibaren 2 şerli verileri al anlmanına gelir Yani 1 2,3 4,5 6,7 8,9 10
    ////Take(2) --Skip(2) denilirse ilk 2 tanesini atlar 3 4,5 6, 7 8,9 10 şeklinde verileri getirir

    ////ön tanımlı sql cumleciği yazma işleminde ToSqlQuery


    ////Sayfalama işlemi için 2 öneli metod vardır Take ve Skip methodları 
    ////Take(5) 5 adet kayıt getir manasına gelir
    ////Skip(5) Atlama işlemi gerçekleştir 10 kayıt varsa 5 ini atlar sonraki 5 datayı getiri

    var products = await context.Products.FromSqlRaw("select * from products").ToListAsync();


    Console.WriteLine("");
}
