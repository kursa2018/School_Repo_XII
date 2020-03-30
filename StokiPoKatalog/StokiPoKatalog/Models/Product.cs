using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StokiPoKatalog.Models
{
    public class Product
    {   [Required]
        public int Number { get; set; }
        [Required]
        [MaxLength(40)]
        public string Naimenovanie { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Clients { get; set; }
      
        public int Distributors { get; set; }
        [Required]
        public DateTime Data { get; set; }
        //Тука имаме 2 навигационни свойства!
        public Client Client { get; set; }
        public Distributor Distributor { get; set; }
    }
}
