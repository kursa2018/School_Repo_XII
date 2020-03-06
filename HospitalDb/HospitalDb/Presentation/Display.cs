using HospitalDb.Business;
using HospitalDb.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalDb.Presentation
{
    public class Display
    {
        private int closeOperation = 7;
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
            Console.WriteLine(new string('-',40));
            Console.WriteLine("6.Данни за пациенти");
            Console.WriteLine("7. Изход от програмата");
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
                    case 3:
                        UpdateDoctor();
                        break;
                    case 4:
                        FetchDoctor();
                        break;
                    case 5:
                        DeleteDoctor();
                        break;
                    case 6:
                        AddPatient();
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
        }//List()
        private void AddDoctor()
        {
            Doctor doctor = new Doctor();
            Console.WriteLine("Въведете име на доктор:");
            doctor.Name = Console.ReadLine();
            Console.WriteLine("Въведете специалност на доктор: ");
            doctor.Specialnost = Console.ReadLine();
            Console.WriteLine("Въведете номер на кабинет:");
            doctor.Cabinet = int.Parse(Console.ReadLine());
            doctorsDb.AddDoctor(doctor);
        }//end AddDoctors()
        private void AddPatient()
        {
            Patient patient = new Patient();
            Console.WriteLine("Въведете име на пациент:");
            patient.Name = Console.ReadLine();
            Console.WriteLine("ЕГН: ");
            patient.Egn = Console.ReadLine();
            Console.WriteLine("Лекуващ лекар ID: ");
            patient.DoctorId = int.Parse(Console.ReadLine());
            Console.WriteLine("Лечение(домашно/болнично): ");
            patient.Lechenie = Console.ReadLine();
            Console.WriteLine("Потребителска такса: ");
            patient.Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Резултат от лечението(оздравял/подължение на лечението): ");
            patient.Result = Console.ReadLine();
            //Да се допълни бизнес слоя!!!
            doctorsDb.AddPatient(patient);
        }
        private void UpdateDoctor()
        {
            Console.WriteLine("Въведете Id на доктор: ");
            int id = int.Parse(Console.ReadLine());
            Doctor doctor = doctorsDb.GetDoctor(id);
            if (doctor!=null)
            {
                Console.WriteLine("Въведи име: ");
                doctor.Name = Console.ReadLine();
                Console.WriteLine("Въведи специалност: ");
                doctor.Specialnost = Console.ReadLine();
                Console.WriteLine("Въведи кабинет: ");
                doctor.Cabinet = int.Parse(Console.ReadLine());
                doctorsDb.UpdateDoctor(doctor);
            }
            else
            {
                Console.WriteLine("Докторът не съществува!");
            }
        }//end Update()
        private void FetchDoctor()
        {
            Console.WriteLine("Въведете Id на лекар: ");
            int id = int.Parse(Console.ReadLine());
            Doctor doctor = doctorsDb.GetDoctor(id);
            if (doctor!=null)
            {
                Console.WriteLine(new string('-',40));
                Console.WriteLine($"ID:-> {doctor.Id}");
                Console.WriteLine($"Име:-> {doctor.Name}");
                Console.WriteLine($"Специалност:-> {doctor.Specialnost}");
                Console.WriteLine($"Кабинет:-> {doctor.Cabinet}");
                Console.WriteLine(new string('-', 40));
            }
        }//end Fetch()
        private void DeleteDoctor()
        {
            Console.WriteLine("Въведете ID на доктор за изтриване: ");
            int id = int.Parse(Console.ReadLine());
            doctorsDb.DeleteDoctor(id);
            Console.WriteLine("Докторът е изтрит!!!");
        }//end DelDoc()
    }
}
