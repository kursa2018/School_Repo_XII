using PerformersConcerts.Models;
using System;

namespace PerformersConcerts
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ConcertPerformersDbContext();
            //Създаваме БД
            //context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            //var performer1 = new Performer();
            //performer1.Name = "Шъная Туейн";
            //performer1.Nationality = "Канада";
            //performer1.VidMusicks = "Кънтри";
            //context.Performers.Add(performer1);

            //var performer2 = new Performer();
            //performer2.Name = "Род Стюърт";
            //performer2.Nationality = "Великобритания";
            //performer2.VidMusicks = "рок";
            //context.Performers.Add(performer2);

            //var performer3 = new Performer();
            //performer3.Name = "Дженифър Лопес";
            //performer3.Nationality = "Пуерто Рико";
            //performer3.VidMusicks = "латино";
            //context.Performers.Add(performer3);

            //var performer4 = new Performer();
            //performer4.Name = "Бритни Спиърс";
            //performer4.Nationality = "САЩ";
            //performer4.VidMusicks = "поп музика";
            //context.Performers.Add(performer4);

            //context.SaveChanges();
        }
    }
}
