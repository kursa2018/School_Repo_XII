using HospitalDb.Models;
using HospitalDb.Presentation;
using System;

namespace HospitalDb
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new HospitalDbContext();
            //Изтриваме и създаваме BD
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            Doctor d1 = new Doctor();
            d1.Cabinet = 202;
            d1.Name = "Статко Статков";
            d1.Specialnost = "уши нос и гърло";
            context.Add(d1);
            //................
            Doctor d2 = new Doctor();
            d2.Cabinet = 232;
            d2.Name = "Петър Гроздарев";
            d2.Specialnost = "офталмолог";
            context.Add(d2);
            context.SaveChanges();
            //................
            Doctor d3 = new Doctor();
            d3.Cabinet = 569;
            d3.Name = "Халил Доспатлийски";
            d3.Specialnost = "гинеколог";
            context.Add(d3);
            context.SaveChanges();
            //................
            Doctor d4 = new Doctor();
            d4.Cabinet = 500;
            d4.Name = "Стефан Папанов";
            d4.Specialnost = "психиатър";
            context.Add(d4);
            context.SaveChanges();
            //..................
            Doctor d5 = new Doctor();
            d5.Cabinet = 400;
            d5.Name = "Алиш Алишов";
            d5.Specialnost = "уши нос и гърло";
            context.Add(d5);
            context.SaveChanges();
            //...........................
            Patient p1 = new Patient();
            p1.Name = "Кевин Балиев";
            p1.Egn = "8923339874";
            p1.DoctorId = 1;
            p1.Lechenie = "домашно от корона вирус";
            p1.Result = "оздравял";
            p1.Price = 456.45;
            context.Add(p1);
            context.SaveChanges();
            //...................
            Display displayDoctors = new Display();
        }
    }
}
