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
            //��������� � ��������� BD
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            Doctor d1 = new Doctor();
            d1.Cabinet = 202;
            d1.Name = "������ �������";
            d1.Specialnost = "��� ��� � �����";
            context.Add(d1);
            //................
            Doctor d2 = new Doctor();
            d2.Cabinet = 232;
            d2.Name = "����� ���������";
            d2.Specialnost = "����������";
            context.Add(d2);
            context.SaveChanges();
            //................
            Doctor d3 = new Doctor();
            d3.Cabinet = 569;
            d3.Name = "����� ������������";
            d3.Specialnost = "���������";
            context.Add(d3);
            context.SaveChanges();
            //................
            Doctor d4 = new Doctor();
            d4.Cabinet = 500;
            d4.Name = "������ �������";
            d4.Specialnost = "���������";
            context.Add(d4);
            context.SaveChanges();
            //..................
            Doctor d5 = new Doctor();
            d5.Cabinet = 400;
            d5.Name = "���� ������";
            d5.Specialnost = "��� ��� � �����";
            context.Add(d5);
            context.SaveChanges();
            //...........................
            Patient p1 = new Patient();
            p1.Name = "����� ������";
            p1.Egn = "8923339874";
            p1.DoctorId = 1;
            p1.Lechenie = "������� �� ������ �����";
            p1.Result = "��������";
            p1.Price = 456.45;
            context.Add(p1);
            context.SaveChanges();
            //...................
            Display displayDoctors = new Display();
        }
    }
}
