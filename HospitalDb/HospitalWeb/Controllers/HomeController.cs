using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HospitalWeb.Models;
using HospitalDb;
using HospitalDb.Models;
using HospitalDb.Business;

namespace HospitalWeb.Controllers
{
    public class HomeController : Controller
    {
        public int Doctors { get; private set; }

        public IActionResult Index()
        {
           

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            DoctorsClients d = new DoctorsClients();
            List<Doctor> doctors = d.GetAllDoctors();

            return View(doctors);
        }

        public IActionResult Patient()
        {
            
            DoctorsClients d = new DoctorsClients();
            List<Doctor> doctors = d.GetAllDoctors();
            List<Patient> patients =doctors.SelectMany(x=>x.Patients).ToList();
            return View(patients);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
