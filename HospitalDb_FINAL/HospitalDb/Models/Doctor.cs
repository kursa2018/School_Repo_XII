using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HospitalDb.Models
{
    public class Doctor
    {   [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Specialnost { get; set; }
        [Required]
        public int Cabinet { get; set; }
        //Навигационно свойство към Patient
        public ICollection<Patient> Patients { get; set; }
        public Doctor()
        {
            this.Patients = new HashSet<Patient>();
        }
    }
}
