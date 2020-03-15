using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Katalogna_targovia.Models
{
    public class Product
    {   [Key]
        public int Number { get; set; }
        [Required]
        [MaxLength(30)]
        public string NameProduct { get; set; }
        public int? CuantityProduct { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string KlientId { get; set; }
        [Required]
        public int DistributorId { get; set; }
        //Навигационно свойство
        public Client Client { get; set; }
        public Distributor Distributor { get; set; }
    }
}
