using avtopark.Business;
using avtopark.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace avtopark.Presentations
{
    public class Display
    {
        private int closeOperationId = 6;
        private ProductBussines product=new ProductBussines();
        public Display()
        {
            Input();
        }
        private void ShowMenu()
        {
            Console.WriteLine(new string('-',40));
            Console.WriteLine(new string('-',18)+"MENU"+new string('-',18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List All entries");
            Console.WriteLine("2. Add new entry");
            Console.WriteLine("3. Update entry");
            Console.WriteLine("4. Fetch entry by ID");
            Console.WriteLine("5. Delete entry by ID");
            Console.WriteLine("6. Exit");
        }//end ShowMenu
        private void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                switch (operation)
                {
                    case 1:
                        ListAll();
                        break;
                    case 2:
                        Add();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Fetch();
                        break;
                    case 5:
                        Delete();
                        break;
                    default:
                        break;
                }
                operation = int.Parse(Console.ReadLine());
            } while (operation!=closeOperationId);
           
        }//end input()
        private void ListAll()
        {
            //Console.WriteLine(new string('-', 40));
            //Console.WriteLine(new string('-', 18) + "MENU" + new string('-', 18));
            //Console.WriteLine(new string('-', 40));
            var cars = product.GetAll();
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Id} {item.Model} {item.Color} {item.Model} {item.PriceNaem}");
            }
        }//end ListAll()
        private void Add()
        {
            Car car = new Car();
            Console.WriteLine("Entered Id:");
            car.Id = Console.ReadLine();
            Console.WriteLine("Entered Model:");
            car.Model = Console.ReadLine();
            Console.WriteLine("Entered color: ");
            car.Color = Console.ReadLine();
            Console.WriteLine("Entered YearMeking: ");
            car.YearMaking = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Entered PriceNaem: ");
            car.PriceNaem = double.Parse(Console.ReadLine());
            product.AddCar(car);
            
        }//end Add();
        private void Update()
        {
            Console.WriteLine("Entered Id to Update: ");
            string id = Console.ReadLine();
            Car car = product.GetCar(id);
            if (car!=null)
            {
                Console.WriteLine("Entered Id:");
                car.Id = Console.ReadLine();
                Console.WriteLine("Entered Model:");
                car.Model = Console.ReadLine();
                Console.WriteLine("Entered color: ");
                car.Color = Console.ReadLine();
                Console.WriteLine("Entered YearMeking: ");
                car.YearMaking = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Entered PriceNaem: ");
                car.PriceNaem = double.Parse(Console.ReadLine());
                product.UpdateCar(car);
            }
            else
            {
                Console.WriteLine("Car is not found!!!");
            }
        }//end Update()
        private void Fetch()
        {
            Console.WriteLine("Enter ID to fetch:");
            string id = Console.ReadLine();
            Car car = product.GetCar(id);
            if (car!=null)
            {
                Console.WriteLine(new string('-',40));
                Console.WriteLine($"ID: {car.Id}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Color: {car.Color}");
                Console.WriteLine($"YearMaking: {car.YearMaking}");
                Console.WriteLine($"PriceNaem: {car.PriceNaem}");
                Console.WriteLine(new string('-', 40));
            }
        }//ent Fetch()
        private void Delete()
        {
            Console.WriteLine("Enter ID to delete:");
            string id = Console.ReadLine();
            product.DeleteCar(id);
            Console.WriteLine("Done.");
        }

    }
}
