// See https://aka.ms/new-console-template for more information
using EFCORE6.CodeFirst.DAL;
using EFCORE6.CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");


//using (var context = new AppDbContext(DbContextInitializer.OptionsBuilder.Options))
using (var context = new AppDbContext())
{
    //// First methodu ile kayıt bulunamadığı taktirde exception fırlatılır
    //var products=context.Products.First(x=>x.Id==18);


    // //FirstOrDefault methodu ile kayıt bulunamadığı taktirde null döner
    //var products = context.Products.FirstOrDefault(x => x.Id == 18);


    ////Single methodu ile eşleşen birden fazla kayıt bulunduğun taktirde excepiton döner
    //var products = context.Products.Single(x => x.Id <= 18);


    ////Where methodu ile eşleşen bir kayıt bulunmadığı taktirde null döner
    //var products = context.Products.Where(x => x.Id <= 18);


    //Find methodu id ile arama işlemlerinde kullanılır tek bir kayıt için kullanılmaktadır
    // bulamadığı taktirde null dönecektir hata forlatmasını istersek single kullanılır
    var products = context.Products.Find(17);

    Console.WriteLine( products.Barcode);
}