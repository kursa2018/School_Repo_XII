using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PerformersConcerts.Models
{
    public class Concert
    {   [Key]
        //Идентификатор на концерт на изпълнител
        public int Id { get; set; }
        //Име на концерта
        [Required]
        public string Name { get; set; }
        //Място на провеждане
        [Required]
        public string Place { get; set; }
        //Дата за провеждане
        [Required]
        public DateTime? Data { get; set; }
        //Идентификатор на изпълнител
        [ForeignKey("Performer")]
        public int Performer { get; set; }
        //Цена на билета
        public double Price { get; set; }
        //Навигационно поле
        public Performer Performers { get; set; }
    }
}
