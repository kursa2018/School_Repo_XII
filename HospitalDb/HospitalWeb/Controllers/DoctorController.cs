using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalDb;
using HospitalDb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalWeb.Controllers
{
    public class DoctorController : Controller
    {
        private HospitalDbContext hospitalDb;
        public DoctorController(HospitalDbContext hospitalDb)
        {
            this.hospitalDb = hospitalDb;
        }
        public async Task<IActionResult> Index()
        {
            List<Doctor> doctors =await hospitalDb.Doctors.ToListAsync();
            return View(doctors);
        }

        // GET: Doctor/Create
        public IActionResult Create()
        {
            Doctor model = new Doctor();

            return View(model);
        }

        // POST: Doctor/Create        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Doctor createModel)
        {
            if (ModelState.IsValid)
            {
                Doctor doctor = new Doctor
                {
                    Name = createModel.Name,
                    Specialnost = createModel.Specialnost,
                    Cabinet = createModel.Cabinet,
                    Patients = createModel.Patients
                };

                hospitalDb.Add(doctor);
                await hospitalDb.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(createModel);
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Doctor foundDoctor = await hospitalDb.Doctors.FindAsync(id);
            if (foundDoctor == null)
            {
                return NotFound();
            }

            return View(foundDoctor);
        }
        // GET: Doctor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Doctor foundDoctor = await hospitalDb.Doctors.FindAsync(id);
            if (foundDoctor == null)
            {
                return NotFound();
            }

            Doctor model = new Doctor
            {
                Name = foundDoctor.Name,
                Specialnost = foundDoctor.Specialnost,
                Cabinet = foundDoctor.Cabinet,
                Patients = foundDoctor.Patients
            };

            return View(model);
        }

        // POST: Doctor/Edit/5       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Doctor editModel)
        {
            if (ModelState.IsValid)
            {
                Doctor doctor = new Doctor
                {
                    Id=editModel.Id,
                    Name = editModel.Name,
                    Specialnost = editModel.Specialnost,
                    Cabinet = editModel.Cabinet,
                    Patients = editModel.Patients
                };

                try
                {
                    hospitalDb.Update(doctor);
                    await hospitalDb.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoctorExists(doctor.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            return View(editModel);
        }

        // GET: Doctor/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            Doctor doctor = await hospitalDb.Doctors.FindAsync(id);
            hospitalDb.Doctors.Remove(doctor);
            await hospitalDb.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        private bool DoctorExists(int id)
        {
            return hospitalDb.Doctors.Any(e => e.Id == id);
        }
    }
}