// See https://aka.ms/new-console-template for more information
using EFCORE6.Inheritance.DAL;
using EFCORE6.Inheritance.Models;

Console.WriteLine("Hello, World!");


using (var context = new AppDbContext())
{
    context.Persons.Add(new Manager() { Age = 1 ,Grade=1,Name="Kurumsal",SurName= "Yönetici" });
    context.Persons.Add(new Employee() { Age = 1 ,Salary=100,Name="Kurumsal",SurName= "Personel" });

    context.SaveChanges();
}