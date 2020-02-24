using PerformersConcerts.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PerformersConcerts
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ConcertPerformersDbContext();
            //Създаваме БД
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            var performer1 = new Performer();
            performer1.Name = "Шъная Туейн";
            performer1.Nationality = "Канада";
            performer1.VidMusicks = "Кънтри";
            context.Performers.Add(performer1);

            var performer2 = new Performer();
            performer2.Name = "Род Стюърт";
            performer2.Nationality = "Великобритания";
            performer2.VidMusicks = "рок";
            context.Performers.Add(performer2);

            var performer3 = new Performer();
            performer3.Name = "Дженифър Лопес";
            performer3.Nationality = "Пуерто Рико";
            performer3.VidMusicks = "латино";
            context.Performers.Add(performer3);

            var performer4 = new Performer();
            performer4.Name = "Бритни Спиърс";
            performer4.Nationality = "САЩ";
            performer4.VidMusicks = "поп музика";
            context.Performers.Add(performer4);
            //Таблица концерти
           
            var concert1 = new Concert();
            concert1.Name = "Да спасим света";
            concert1.Performer = 1;
            concert1.Place = "Читалището Велинград";
            concert1.Data = new DateTime(2020, 02, 19);
            concert1.Price = 14.25;
            context.Concerts.Add(concert1);
            var concert2 = new Concert();
            concert2.Name = "Да изберем Доналт Тръмп";
            concert2.Performer = 1;
            concert2.Place = "Дом на културата";
            concert2.Data = new DateTime(2020, 03, 08);
            concert2.Price = 30.36;
            context.Concerts.Add(concert2);
            var concert3 = new Concert();
            concert3.Name = "Спасете Грета Тумберг";
            concert3.Performer = 2;
            concert3.Place = "София - НДК";
            concert3.Data = new DateTime(2020, 06, 22);
            concert3.Price = 30.36;
            context.Concerts.Add(concert3);
            context.SaveChanges();

            //List<Performer> items = context.Performers.ToList();
            //foreach (var e in items)
            //{
            //    Console.WriteLine($"{e.Name} -> {e.Nationality}");
            //}
            //Печат на концертите
            //var concerts = context.Concerts.Where(x => x.Performer == 1).ToList();
            //concerts.ForEach(x => Console.WriteLine($"{x.Performer} {x.Name} {x.Price:f2}"));
        }
    }
}
