using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HospitalDb.Models
{
    public class Patient
    {   [Key]
        public string Egn { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [ForeignKey("DoctorId")]
        [Column("Doctor")]
        public int DoctorId { get; set; }
        [Required]
        public string Lechenie { get; set; }
        [Required]
        public string Result { get; set; }
        public double? Price { get; set; }
        //Навигация към таблица Доктор
        public Doctor Doctor { get; set; }
    }
}
