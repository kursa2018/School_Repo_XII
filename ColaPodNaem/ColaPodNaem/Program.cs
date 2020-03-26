using ColaPodNaem.Model;
using ColaPodNaem.Presentation;
using System;

namespace ColaPodNaem
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new avtoparkColiClientyDbContext();
            //...............
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            //.............
            //***********************

            // Процедурите за обработка на клиенти->Add(),Delete(),Fetch(),Update()
            //************************
            Car c1 = new Car();
            c1.Id = "AS1020";
            c1.Model = "Trabant";
            c1.Color = "бял";
            c1.PriceNaem = 11.58m;
            c1.YearMaking = new DateTime(2010, 06, 11);
            context.Add(c1);
            context.SaveChanges();
            //-------------------
            Car c2 = new Car();
            c2.Id = "AS1111";
            c2.Model = "Shkoda";
            c2.Color = "червен";
            c2.PriceNaem = 23.56m;
            c2.YearMaking = new DateTime(2010, 06, 11);
            context.Add(c2);
            context.SaveChanges();
            //--------------------
            Car c3 = new Car();
            c3.Id = "AF5963";
            c3.Model = "Lada-Samara 1600";
            c2.Color = "червен";
            c3.PriceNaem = 36.54m;
            c3.YearMaking = new DateTime(2010, 06, 11);
            context.Add(c3);
            context.SaveChanges();
            //..............................
            Client cl1 = new Client();
            cl1.Name = "Иван";
            cl1.Family = "Петров";
            cl1.Karta = 1258;
            cl1.Adress = "Юндола 11";
            cl1.CreditCard = "BG15963578";
            cl1.VzetaData = new DateTime(2010, 06, 03);
            cl1.Kola = "AS1111";
            context.Add(cl1);
            context.SaveChanges();
            //.........................
            Display display = new Display();
        }
    }
}
