using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Katalogna_targovia.Models
{
    public class Distributor
    {   [Key]
        public int DistId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Recuaer]
        public string Tel { get; set; }
        public ICollection<Product> Products { get; set; }
        public Distributor()
        {
            this.Products = new HashSet<Product>();
        }
    }
}
