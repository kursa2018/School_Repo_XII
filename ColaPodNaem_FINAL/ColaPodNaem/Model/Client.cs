using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ColaPodNaem.Model
{
    public  class Client
    {
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Family { get; set; }
        [Column("LichnaKarta")]
        [Required]
        public int Karta { get; set; }
        [MaxLength(100)]
        public string Adress { get; set; }
        [Column("CreditCard")]
        [Required]
        public string CreditCard { get; set; }
        [Column("Data")]
        [Required]
        public DateTime VzetaData { get; set; }
        [Key]
        public string Kola { get; set; }
        //Навигационно свойство
        public Car Car { get; set; }
    }
}
