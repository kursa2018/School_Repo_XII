using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KoliPodNaem.Data
{
    public class Client
    {   [Recuared]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Familia { get; set; }
        [Recuared]
        public int KartaNumber { get; set; }
        [Recuared]
        [MaxLength(100)]
        public string Adress { get; set; }
        [Recuared]
        [MaxLength(20)]
        public string CreditCart { get; set; }
        [Recuared]
        [Key]
        public DateTime DateNaem { get; set; }
        [Required]
        [ForeignKey("KolaNomer")]
        public string CarNaem { get; set; }
        //Навигационно свойство
        public Car Car { get; set; }
    }
}
