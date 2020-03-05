using HospitalDb.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalDb.Presentation
{
    public class Display
    {
        private int closeOperation = 6;
        private DoctorsClients doctorsDb=new DoctorsClients();
        private void ShowMenu()
        {
            Console.WriteLine(new string('*',40));
            Console.WriteLine(new string(' ',18)+"MENU"+new string(' ',18));
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("1.Списък на лекарите: ");
            Console.WriteLine("2. Добавяне на лекар: ");
            Console.WriteLine("3. Актуализиране на данни за лекар: ");
            Console.WriteLine("4. Откриване на лекар по Id: ");
            Console.WriteLine("5. Изтриване на лекар по Id: ");
            Console.WriteLine("6. Изход от програмата");
        }//end Show()
        public void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                //....
                switch (operation)
                {
                    case 1:
                        ListAllDoctors();
                        break;
                    case 2:
                        AddDoctor();
                        break;
                }
                //....

            } while (operation!=closeOperation);
        }//end input()
        public Display()
        {
            Input();
        }//end constructor
        private void ListAllDoctors()
        {
            Console.WriteLine(new string('*', 40));
            Console.WriteLine(new string(' ', 16) + "MENU" + new string(' ', 16));
            Console.WriteLine(new string('*', 40));
            var doctors = doctorsDb.GetAllDoctors();
            foreach (var item in doctors)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Cabinet} {item.Specialnost}");
            }
        }
    }
}
