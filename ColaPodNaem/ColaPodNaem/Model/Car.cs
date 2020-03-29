using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ColaPodNaem.Model
{
    public class Car
    {   [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Model { get; set; }
        [MaxLength(20)]
        public string Color { get; set; }
        [Required]
        public DateTime YearMaking { get; set; }
        [Required]
        public decimal PriceNaem { get; set; }
        //Навигационно поле!
        public Client Client { get; set; }
    }
}
