using StokiPoKatalog.Models;
using StokiPoKatalog.Presentation;
using System;

namespace StokiPoKatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new CatalogDbContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            //Създаваме инстанция на класа Display
            Client cl1 = new Client();
            cl1.Egn = "2569871456";
            cl1.Name = "Калитко Калитков";
            cl1.Adress = "Бургас Калиакра №4";
            cl1.Tel = "0359/51478";
            context.Add(cl1);
            context.SaveChanges();
            //--------------------------
            Client cl2 = new Client();
            cl2.Egn = "1569877774";
            cl2.Name = "Спиридон Спиридонов";
            cl2.Adress = "Велинград Пионерска №40";
            cl2.Tel = "0359/569874";
            context.Add(cl2);
            context.SaveChanges();
            //-----------------------------
            Distributor d1 = new Distributor();
            d1.Name = "Петър Петров";
            d1.TelContact = "08856924747";
            context.Add(d1);
            context.SaveChanges();
            //-----------------------------
            Product p1 = new Product();
            p1.Clients = "2569871456";
            p1.Data = new DateTime(2020, 03, 14);
            p1.Number = 1000;
            p1.Quantity = 23;
            p1.Price = 23.47;
            p1.Naimenovanie = "Тоалетна хартия";
            p1.Distributors = 1;
            context.Add(p1);
            context.SaveChanges();
            Display display = new Display();        
        }
    }
}
