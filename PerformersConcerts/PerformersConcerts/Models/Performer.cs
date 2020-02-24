using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PerformersConcerts.Models
{
    public class Performer
    {   [Key]
        //Идентификатор на изпълнител
        public int Id { get; set; }
        //Име на изпълнителя
        public string Name { get; set; }
        //Националност на изпълнителя
        public string Nationality { get; set; }
        //Вид музика
        public string VidMusicks { get; set; }
        //Колекция от концерти 1,2,3....
        public ICollection<Concert> Concerts { get; set; }
        public Performer()
        {
            this.Concerts = new HashSet<Concert>();
        }
    }
}
