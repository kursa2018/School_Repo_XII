using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StokiPoKatalog.Models
{
    public class Distributor
    {   [Key]
        public int DistrId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public string TelContact { get; set; }
        //Навигационно свойство
        public ICollection<Product> Products { get; set; }
        public Distributor()
        {
            this.Products = new HashSet<Product>();
        }
    }
}
