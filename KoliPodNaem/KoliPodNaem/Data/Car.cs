using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KoliPodNaem.Data
{
    public class Car
    {   [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Model { get; set; }
        [Required]
        [MaxLength(20)]
        public string Color { get; set; }
        [Required]
        public DateTime YearManufactured { get; set; }
        [Required]
        public decimal PriceNaem { get; set; }
        //Навигационно поле
        public Client Client { get; set; }
    }
}
