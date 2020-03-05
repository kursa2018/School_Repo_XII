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
            Display displayDoctors = new Display();
        }
    }
}
