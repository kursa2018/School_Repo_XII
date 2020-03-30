using System;
using System.Collections.Generic;

namespace ColaPodNaem.Models
{
    public partial class Cars
    {
        public string Id { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public DateTime YearMaking { get; set; }
        public decimal PriceNaem { get; set; }

        public virtual Clients Clients { get; set; }
    }
}
