using StokiPoKatalog.Business;
using StokiPoKatalog.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StokiPoKatalog.Presentation
{
    public class Display
    {
        private int closeOperation = 6;
        private ProductBusiness productBusines = new ProductBusiness();
        public Display()
        {
            Input();
        }
        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "Меню Клиенти" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. Списък на клиентите на магазина: ");
            Console.WriteLine("2. Добавяне на клиент: ");
            Console.WriteLine("3. Актуализиране данни на клиент: ");
            Console.WriteLine("4. Търсене на клиент по ЕГН: ");
            Console.WriteLine("5. Изтриване на клиент по ЕГН: ");
            Console.WriteLine("6.Изход от програмата");
        }//end
        private void Input()
        {
            var operation = -1;
            do
            {    //Да се вмъкне метода ShoWMenu();
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ListAllClients();
                        break;
                    case 2:
                        AddClient();
                        break;
                    case 3:
                        UpdateClient();
                        break;
                    case 4:
                        //FetchClient();
                        break;
                    case 5:
                        //DeleteClient();
                        break;
                                          
                }

            } while (operation!=closeOperation);

        }//end input()

        private void ListAllClients()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "Списък на клиенти" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var clients = productBusines.GetAllClients();
            foreach (var item in clients)
            {
                Console.WriteLine($"Клиент: {item.Name} {item.Egn} {item.Adress} {item.Tel}");
            }
            
        }//end AllCliEnts()
        private void AddClient()
        {
            Client client = new Client();
            Console.WriteLine("Въведете име на клиент: ");
            client.Name = Console.ReadLine();
            Console.WriteLine("Въведете ЕГН на клиент: ");
            client.Egn = Console.ReadLine();
            Console.WriteLine("Въведете адрес: ");
            client.Adress = Console.ReadLine();
            Console.WriteLine("Въведете телефон на клиента: ");
            client.Tel = Console.ReadLine();
            productBusines.AddClient(client);
        }//end AddClient()
        public void UpdateClient()
        {
            Console.WriteLine("Въведете ЕГН на клиент: ");
            string egn = Console.ReadLine();
            Client client = productBusines.GetClient(egn);
            if (client!=null)
            {
                Console.WriteLine("Въведете име на клиент: ");
                client.Name = Console.ReadLine();
                Console.WriteLine("Въведете ЕГН на клиент: ");
                client.Egn = Console.ReadLine();
                Console.WriteLine("Въведете адрес на клиент: ");
                client.Adress = Console.ReadLine();
                Console.WriteLine("Въведете телефон на клиент: ");
                client.Tel = Console.ReadLine();
                productBusines.UpdateClient(client);
            }
            else
            {
                Console.WriteLine($"Клиент с посоченото ЕГН: {egn} не съществува!");
            }
        }//end UpdateClient()
    }
}
