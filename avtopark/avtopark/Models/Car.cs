using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace avtopark.Models
{
    public class Car
    {   [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Model { get; set; }
        [Required]
        [MaxLength(10)]
        public string Color { get; set; }
        public DateTime? YearMaking { get; set; }
        [Required]
        public double PriceNaem { get; set; }
        //Навигационно свойство
        public Client Client { get; set; }
    }
}
