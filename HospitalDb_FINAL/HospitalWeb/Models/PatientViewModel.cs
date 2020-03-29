using HospitalDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalWeb.Models
{
    public class PatientViewModel
    {
       public List<Doctor> doctors;
       public List<Patient> patients;
        public PatientViewModel()
        {
            doctors = new List<Doctor>();
            patients = new List<Patient>();
        }
    }
}
