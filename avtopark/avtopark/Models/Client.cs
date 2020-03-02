using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace avtopark.Models
{
    public class Client
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public string Family { get; set; }
        [Required]
        [MaxLength(40)]
        public int Idcard { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]

        public string Creditcard { get; set; }
        [Required]
        [Key]
        public string CarOnLoan { get; set; }
        public Car Car { get; set; }

    }
}
