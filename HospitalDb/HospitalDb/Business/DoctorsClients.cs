using HospitalDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalDb.Business
{
    public class DoctorsClients
    {
        private HospitalDbContext hospitalDbContext;
        public List<Doctor>GetAllDoctors()
        {
            using (hospitalDbContext = new HospitalDbContext())
            {
                return hospitalDbContext.Doctors.ToList();
            }
        }//end Doctors
        public Doctor GetDoctor(int id)
        {
            using (hospitalDbContext = new HospitalDbContext())
            {
                return hospitalDbContext.Doctors.Find(id);
            }
        }//end Get()
        public void AddDoctor(Doctor doctor)
        {
            using (hospitalDbContext = new HospitalDbContext())
            {
                hospitalDbContext.Doctors.Add(doctor);
                hospitalDbContext.SaveChanges();
            }
        }//end AddDoctor()
        public void AddPatient(Patient patient)
        {
            using (hospitalDbContext = new HospitalDbContext())
            {
                hospitalDbContext.Patients.Add(patient);
                hospitalDbContext.SaveChanges();
            }
        }

        public void UpdateDoctor(Doctor doctor)
        {
            using (hospitalDbContext = new HospitalDbContext())
            {
                var item = hospitalDbContext.Doctors.Find(doctor.Id);
                if (item!=null)
                {
                    hospitalDbContext.Entry(item).CurrentValues.SetValues(doctor);
                    hospitalDbContext.SaveChanges();
                }
            }
        }//end Update()
        public void DeleteDoctor(int id)
        {
            using (hospitalDbContext = new HospitalDbContext())
            {
                var item = hospitalDbContext.Doctors.Find(id);
                if (item!=null)
                {
                    hospitalDbContext.Doctors.Remove(item);
                    hospitalDbContext.SaveChanges();
                }
            }
        }//end Delete()

    }
}
