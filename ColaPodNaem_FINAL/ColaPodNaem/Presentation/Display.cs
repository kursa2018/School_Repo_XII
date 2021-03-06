﻿using ColaPodNaem.Business;
using ColaPodNaem.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColaPodNaem.Presentation
{
    public class Display
    {
        private int closeOperation = 7;
        private CarClientBusiness avtopark=new CarClientBusiness();
        public void ShowMenu()
        {
            Console.WriteLine(new string('*',40));
            Console.WriteLine(new string(' ',18)+"Меню"+new string(' ',18));
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("1. Списък на автопарка");
            Console.WriteLine("2. Добави автомобил: ");
            Console.WriteLine("3. Актуализиране на данни за кола: ");
            Console.WriteLine("4. Търси автомобил по ID: ");
            Console.WriteLine("5. Изтриване на автомобил от автопарка (ID): ");
            Console.WriteLine(new string('*',40));
            Console.WriteLine("6. Вход на данни за клиенти: ");
            Console.WriteLine("7. Изход от програмата");
        }//end ShowMenu()
        public Display()
        {
            Input();
        }
        private void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ListAvtopark();
                        break;
                    case 2:
                        AddCar();
                        break;
                    case 3:
                        UpdateCar();
                        break;
                    case 4:
                        FetchCar();
                        break;
                    case 5:
                        DeleteCar();
                        break;
                }
            } while (operation!=closeOperation);
        }//end Input()
        public void ListAvtopark()
        {
            Console.WriteLine(new string('*', 40));
            Console.WriteLine(new string(' ', 18) + "Списък на автопарка" + new string(' ', 18));
            Console.WriteLine(new string('*', 40));
            var cars = avtopark.GetAllCars();
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Id}. {item.Model} {item.Color} {item.YearMaking.Year}.{item.YearMaking.Month}.{item.YearMaking.Day} -> {item.PriceNaem:f2}");
            }
        }//end ListAvtopark()
        public void AddCar()
        {
            Car car = new Car();
            Console.WriteLine("Въведете регистрационен номер: ");
            car.Id = Console.ReadLine();
            Console.WriteLine("Въведете модел на колата:");
            car.Model = Console.ReadLine();
            Console.WriteLine("Цвят на колата ?: ");
            car.Color = Console.ReadLine();
            Console.WriteLine("Година на производство: ");
            car.YearMaking = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Цена за час?: ");
            car.PriceNaem = decimal.Parse(Console.ReadLine());
            avtopark.AddCar(car);
        }//end AddCar()
        public void UpdateCar()
        {
            Console.WriteLine("Променете данни за кола с рег. номер Id:");
            string id = Console.ReadLine();
            Car car = avtopark.GetCar(id);
            if (car!=null)
            {
              
                Console.WriteLine("Въведете модел на кола: ");
                car.Model = Console.ReadLine();
                Console.WriteLine("Въведете цвят на колата: ");
                car.Color = Console.ReadLine();
                Console.WriteLine("Въведете цена под наем: ");
                car.PriceNaem = decimal.Parse(Console.ReadLine());
                avtopark.UpdateCar(car);
            }
            else
            {
                Console.WriteLine("Няма кола с такъв регистрационен номер!");
            }
        }//end Update()
        public void FetchCar()
        {
            Console.WriteLine("Въведете търсен автомобил по Id: ");
            string Id = Console.ReadLine();
            Car car = avtopark.GetCar(Id);
            if (car!=null)
            {
                Console.WriteLine(new string('*',40));
                Console.WriteLine("ID: "+car.Id);
                Console.WriteLine("Модел: "+car.Model);
                Console.WriteLine("Цвят: "+car.Color);
                Console.WriteLine("Цена под наем: {0:f2}",car.PriceNaem);
                Console.WriteLine(new string('*', 40));
            }
        }//end Fetch()
        public void DeleteCar()
        {
            Console.WriteLine("Въведете Id на кола за изтриване: ");
            string Id = Console.ReadLine();
            avtopark.DeleteCar(Id);
            Console.WriteLine("Колата е изтрита:");
        }//end DeleteCar()
    }
}
