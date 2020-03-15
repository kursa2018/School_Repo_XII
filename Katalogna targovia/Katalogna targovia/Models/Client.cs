using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Katalogna_targovia.Models
{
    public class Client
    {
        public string Name { get; set; }
        [Key]
        [MaxLength(10)]
        [Required]
        public string Egn { get; set; }
        [Required]
        public string Adress { get; set; }
        [MaxLength(20)]
        public string Tel { get; set; }
        // Навигационно свойство
        public ICollection<Product> Products { get; set; }
        public Client()
        {
            this.Products = new HashSet<Product>();
        }
    }
}
