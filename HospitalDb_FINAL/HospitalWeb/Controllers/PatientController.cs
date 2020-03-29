using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using HospitalDb;
using HospitalDb.Models;
using HospitalWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace HospitalWeb.Controllers
{
    public class PatientController : Controller
    {
        private readonly HospitalDbContext hospitalDb;
        public PatientController(HospitalDbContext context)
        {
            this.hospitalDb = context;
        }
        public async Task<IActionResult> Index()
        {
            PatientViewModel patients = new PatientViewModel();
            patients.patients = await hospitalDb.Patients.ToListAsync();
            patients.doctors = await hospitalDb.Doctors.Where(x => x.Patients.Any()).ToListAsync();
            
            return View(patients);
        }

        // GET: Patient/Create
        public IActionResult Create()
        {
            Patient model = new Patient();

            return View(model);
        }

        // POST: Patient/Create        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Patient createModel)
        {
            Doctor foundDoctor = await hospitalDb.Doctors.FirstAsync(x => x.Id == createModel.DoctorId);
            if (foundDoctor == null)
            {
                return RedirectToAction("Create", "Doctor");
            }            
            if (ModelState.IsValid)
            {
                Patient patient = new Patient
                {
                    Name = createModel.Name,
                    Egn=createModel.Egn,
                    Lechenie = createModel.Lechenie,
                    Result = createModel.Result,
                    Price = createModel.Price,
                    DoctorId=foundDoctor.Id,
                    Doctor=foundDoctor                    
                };                

                hospitalDb.Add(patient);
                await hospitalDb.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(createModel);
        }
    }
}