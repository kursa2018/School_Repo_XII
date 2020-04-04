using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StokiPoKatalog.Models
{
    public class Client
    {   [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Key]
        public string Egn { get; set; }
        [Required]
        [MaxLength(60)]
        public string Adress { get; set; }
        public string Tel { get; set; }
        //Навигационно свойство
        public ICollection<Product> Products { get; set; }
        public Client()
        {
            this.Products = new HashSet<Product>();
        }

    }
}
